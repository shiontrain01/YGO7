using System.Collections.Generic;
using System.Threading.Tasks;
using YGO7.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using YGO7.Application.Dtos;
using YGO7.Application.Interfaces;

namespace YGO7.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private readonly ICardAppService _cardService;

        public CardController(
        ICardAppService cardAppService)
        {
            _cardService = cardAppService;
        }

        [HttpGet]
        public Task<IListResultDto<EffectMonsterDto>> ListGet() =>
            _cardService.ListGet();

        [HttpGet("{id:length(24)}", Name = "GetCard")]
        public Task<ISingleResultDto<EffectMonsterDto>> GetCard(string id)
        {
            var card = _cardService.GetCard(id);

            return card;
        }

        [HttpPost]
        public ActionResult<Card> Create(EffectMonsterDto card)
        {
            _cardService.Create(card);

            return CreatedAtRoute("GetCard", new { id = card.Id.ToString() }, card);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, EffectMonsterDto cardIn)
        {
            var card = _cardService.GetCard(id);

            if (card == null)
            {
                return NotFound();
            }

            _cardService.Update(id, cardIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var card = _cardService.GetCard(id);

            if (card == null)
            {
                return NotFound();
            }

            _cardService.Delete(card.Id);

            return NoContent();
        }
    }
}