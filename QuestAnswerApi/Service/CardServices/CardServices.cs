using QuestAnswerApi.Models;
using QuestAnswerApi.Repositories.CardRepositories;

namespace QuestAnswerApi.Service.CardServices;

public class CardServices : ICardServices
{
    private readonly CardRepository _cardRepository;
    public CardServices(CardRepository cardRepository)
    {
        this._cardRepository = cardRepository;
    }
    public async Task CreateCard(Card card)
    {
        await _cardRepository.CreateCardAsync(card);
    }

    public async Task<bool> DeleteCard(long id)
    {
        return await _cardRepository.DeleteCardAsync(id);
    }

    public async Task<IEnumerable<Card>> GetAllCards()
    {
        return await _cardRepository.GetAllCardsAsync();
    }

    public async Task<IEnumerable<Card>> GetAllCardsByCategory(string category)
    {
        return await _cardRepository.GetAllCardsByCategoryAsync(category);
    }

    public async Task<Card?> GetCardById(long id)
    {
        return await _cardRepository.GetCardByIdAsync(id);
    }

    public async Task<bool> UpdateCard(Card card)
    {
        return await _cardRepository.UpdateCardAsync(card);
    }
}