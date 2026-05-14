namespace QuestAnswerApi.Interfaces;

public interface IApiKeyValidation
{
    bool IsApiKeyValid(string userApiKey);
}