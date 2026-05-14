using QuestAnswerApi.Constants;
using QuestAnswerApi.Interfaces;

namespace QuestAnswerApi.Middlewares;

public class ApiKeyMiddleware
{
    private readonly RequestDelegate _next;
    private readonly IApiKeyValidation _apiKeyValidation;

    public ApiKeyMiddleware(RequestDelegate next, IApiKeyValidation apiKeyValidation)
    {
        _next = next;
        _apiKeyValidation = apiKeyValidation;
    }

    public async Task Invoke(HttpContext httpContext)
    {
        var userApiKey =  httpContext.Request.Headers[ConstantsApi.ApiKeyHeaderName];
        if (!_apiKeyValidation.IsApiKeyValid(userApiKey))
        {
            httpContext.Response.StatusCode = StatusCodes.Status401Unauthorized;
            return;
        }
        await _next(httpContext);
    }
}