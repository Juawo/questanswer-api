# Estágio 1: Build
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Copia o arquivo de projeto e restaura as dependências
COPY ["QuestAnswerApi.csproj", "./"]
RUN dotnet restore "QuestAnswerApi.csproj"

# Copia o restante dos arquivos e compila
COPY . .
RUN dotnet publish "QuestAnswerApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Estágio 2: Runtime (Imagem final leve)
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

# Define a porta que o .NET vai escutar (padrão do Render é 8080 ou 10000)
ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080

ENTRYPOINT ["dotnet", "QuestAnswerApi.dll"]