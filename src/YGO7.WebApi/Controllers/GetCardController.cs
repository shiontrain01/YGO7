using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YGO7.Application.Dtos;
using YGO7.Application.Interfaces;

namespace YGO7.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetCardController: ControllerBase
    {
        private readonly IGetCardAppService _getCardService;

        public GetCardController(
            IGetCardAppService getCardAppService)
        {
            _getCardService = getCardAppService;
        }

        
        [HttpGet]
        public async Task<IListResultDto<CompleteCardInformationDto>> GetAllCards()
        {
            return await _getCardService.GetAllCards();
        }


        [HttpGet("{id:length(24)}", Name = "GetById")]
        public async Task<IActionResult>  GetById(string id)
        {
            try
            {
                var card = await _getCardService.GetById(id);
                return Ok(card);


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        
    }
}