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
        public async Task<IActionResult> GetAll()
        {
            var card = await _cardService.GetAll();
            return Ok(card);
        }

        [HttpGet("{id:length(24)}", Name = "Get")]
        public async Task<IActionResult> Get(string id)
        {
            var card = await _cardService.Get(id);
            return Ok(card);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CompleteCardInformationDto card)
        {
            try
            {
                card.Id = "";
                var teste = await _cardService.Create(card);
                return Ok(teste);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> Update(string id, CompleteCardInformationDto cardIn)
        {
            var card = _cardService.Get(id);

            if (card == null)
            {
                return NotFound();
            }

            var teste = await _cardService.Update(id, cardIn);

            return Ok(teste);
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