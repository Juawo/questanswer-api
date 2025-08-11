using QuestAnswerApi.DTOs.Request;
using QuestAnswerApi.Models;

namespace QuestAnswerApi.Mappers.CardMappers;

public static class CardMapper
{
    public static Card ToCardFromCreateDto(this CreateCardDto cardDto)
    {
        return new Card
        {
            Answer = cardDto.Answer,
            Category = cardDto.Category,
            Tips = cardDto.Tips
        };
    }
}