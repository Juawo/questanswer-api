namespace QuestAnswerApi.DTOs.Response;

public record CardResponseDto(
    int Id,
    string Answer,
    string Category,
    List<string> Tips);