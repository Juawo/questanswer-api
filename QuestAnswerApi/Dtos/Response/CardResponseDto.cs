namespace QuestAnswerApi.DTOs.Response;

public record CardResponseDto(
    long Id,
    string Answer,
    string Category,
    List<string> Tips);