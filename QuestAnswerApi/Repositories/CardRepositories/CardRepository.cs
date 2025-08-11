namespace QuestAnswerApi.Repositories.CardRepositories;

using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QuestAnswerApi.Models;
using QuestAnswerApi.Repositories;
public class CardRepository : ICardRepository
{
    private readonly ApplicationDBContext _context;

    public CardRepository(ApplicationDBContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Card>> GetAllCardsAsync()
    {
        List<Card> cards = await _context.Cards.ToListAsync();
        return cards;
    }
    
    public async Task<Card> GetCardByIdAsync(int id)
    {
        Card? card = await _context.Cards.FindAsync(id);

        return card;
    }

    public async Task CreateCardAsync(Card card)
    {
        await _context.AddAsync(card);
        await _context.SaveChangesAsync();

    }

    public async Task<bool> DeleteCardAsync(int id)
    {

        Card cardSearch = await GetCardByIdAsync(id);
        _context.Remove(cardSearch);
        return await _context.SaveChangesAsync() > 0;
    }

    public async Task<bool> UpdateCardAsync(Card card)
    {
        _context.Update(card);
        return await _context.SaveChangesAsync() > 0;
    }
}
