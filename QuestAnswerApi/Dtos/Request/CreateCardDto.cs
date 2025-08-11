namespace QuestAnswerApi.DTOs.Request;
public record CreateCardDto(
    string Answer,
    string Category,
    List<string> Tips);