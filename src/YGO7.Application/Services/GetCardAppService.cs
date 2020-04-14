using System;
using System.Threading.Tasks;
using AutoMapper;
using YGO7.Application.Bases;
using YGO7.Application.Dtos;
using YGO7.Application.Interfaces;
using YGO7.Core.Interfaces;

namespace YGO7.Application.Services
{
    public class GetCardAppService:  AppService, IGetCardAppService
    {
        private readonly IGetCardService _service;

        public GetCardAppService(IGetCardService service, IMapper mapper)
            : base(mapper)
        {
            this._service = service;
        }

        public async Task<ISingleResultDto<CompleteCardInformationDto>> GetById(string id)
        {
            var entity = await _service.GetById(id);
            try
            {
                var dto =  Mapper.Map<CompleteCardInformationDto>(entity);
                return  new SingleResultDto<CompleteCardInformationDto>(dto);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
           
        }
    }
}