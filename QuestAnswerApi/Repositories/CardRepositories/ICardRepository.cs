namespace QuestAnswerApi.Repositories.CardRepositories;

using QuestAnswerApi.Models;
public interface ICardRepository
{
    Task<Card?> GetCardByIdAsync(int id);
    Task<IEnumerable<Card>> GetAllCardsAsync();
    Task CreateCardAsync(Card card);
    Task<bool> UpdateCardAsync(Card card);
    Task<bool> DeleteCardAsync(int id);
}
