# Estágio 1: Build
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# 1. Copia o arquivo de projeto respeitando a pasta
# Origem: QuestAnswerApi/QuestAnswerApi.csproj
# Destino dentro do Docker: QuestAnswerApi/
COPY ["QuestAnswerApi/QuestAnswerApi.csproj", "QuestAnswerApi/"]

# 2. Restaura apontando para o caminho onde o arquivo foi copiado
RUN dotnet restore "QuestAnswerApi/QuestAnswerApi.csproj"

# 3. Copia todo o conteúdo da pasta local para o WORKDIR /src
COPY . .

# 4. Muda o diretório de trabalho para onde o código da API realmente está
WORKDIR "/src/QuestAnswerApi"

# 5. Publica a partir da pasta atual
RUN dotnet publish "QuestAnswerApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Estágio 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080

ENTRYPOINT ["dotnet", "QuestAnswerApi.dll"]