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
        public Task<IListResultDto<CompleteCardInformationDto>> GetAllCards()
        {
            return _getCardService.GetAllCards();
        }


        [HttpGet("{id:length(24)}", Name = "GetById")]
        public Task<ISingleResultDto<CompleteCardInformationDto>> GetById(string id)
        {
            var card = _getCardService.GetById(id);

            return card;
        }

        
    }
}