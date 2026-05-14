using QuestAnswerApi.Constants;
using QuestAnswerApi.Interfaces;

namespace QuestAnswerApi.Services;

public class ApiKeyValidation : IApiKeyValidation
{
    private IConfiguration _configuration;

    public ApiKeyValidation(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    
    public bool IsApiKeyValid(string userApiKey)
    {
        if (string.IsNullOrEmpty(userApiKey))
        {
            return false;
        }

        var ApiKey = _configuration.GetValue<string>(ConstantsApi.ApiKeyName);
        if (ApiKey is null || ApiKey != userApiKey)
        {
            return false;
        }
        return true;
    }
}