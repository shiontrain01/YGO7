using System;
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
        public Task<IListResultDto<EffectMonsterDto>> GetAll()
        {
            return _cardService.GetAll();
        }

        [HttpGet("{id:length(24)}", Name = "Get")]
        public Task<ISingleResultDto<EffectMonsterDto>> Get(string id)
        {
            var card = _cardService.Get(id);

            return card;
        }

        [HttpPost]
        public ActionResult<Card> Create(EffectMonsterDto card)
        {
            try
            {
                var teste = _cardService.Create(card);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
                
            }
            return CreatedAtRoute("Get", new { id = card.Id.ToString() }, card);

        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, EffectMonsterDto cardIn)
        {
            var card = _cardService.Get(id);

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
            var card = _cardService.Get(id);

            if (card == null)
            {
                return NotFound();
            }

            _cardService.Delete(id);

            return NoContent();
        }
    }
}