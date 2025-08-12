using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using QuestAnswerApi.DTOs.Request;
using QuestAnswerApi.Mappers.CardMappers;
using QuestAnswerApi.Service.CardServices;
using QuestAnswerApi.Models.Card
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace QuestAnswerApi.Controllers.Card;

[Route("api/[controller]")]
[ApiController]
public class CardController : ControllerBase
{
    private readonly ICardServices _cardServices;
    public CardController(ICardServices cardServices)
    {
        this._cardServices = cardServices;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllCards()
    {
        var cards = await _cardServices.GetAllCards();
        return Ok(cards);
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetCardById([FromRoute] long id)
    {
        var card = await _cardServices.GetCardById(id);
        return Ok(card);
    }

    [HttpPost]
    public async Task<IActionResult> CreateCard([FromBody] CreateCardDto cardDto)
    {
        var card = cardDto.ToCardFromCreateDto();
        await _cardServices.CreateCard(card);
        return CreatedAtAction(nameof(GetCardById), new { id = card.Id });
    }
    [HttpPut]
    [Route("{id}")]
    public async Task<IActionResult> UpdateCard([FromRoute] long id,[FromBody] Card card)
    {
        return Task<IActionResult>;
    }
    [HttpGet]
    public async Task<IActionResult> GetAllCards()
    {
        return Task<IActionResult>;
    }
}
