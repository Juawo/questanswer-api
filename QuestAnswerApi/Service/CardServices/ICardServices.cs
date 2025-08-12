using QuestAnswerApi.Models;

namespace QuestAnswerApi.Service.CardServices;

public interface ICardServices
{
    Task<IEnumerable<Card>> GetAllCards();
    Task<Card?> GetCardById(long id);
    Task CreateCard(Card card);
    Task<bool> UpdateCard(Card card);
    Task<bool> DeleteCard(long id);
}
