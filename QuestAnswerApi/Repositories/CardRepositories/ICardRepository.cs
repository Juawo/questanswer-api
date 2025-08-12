namespace QuestAnswerApi.Repositories.CardRepositories;

using QuestAnswerApi.Models;
public interface ICardRepository
{
    Task<Card?> GetCardByIdAsync(long id);
    Task<IEnumerable<Card>> GetAllCardsAsync();
    Task CreateCardAsync(Card card);
    Task<bool> UpdateCardAsync(Card card);
    Task<bool> DeleteCardAsync(long id);
}
