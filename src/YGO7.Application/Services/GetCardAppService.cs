using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using YGO7.Application.Bases;
using YGO7.Application.Dtos;
using YGO7.Application.Interfaces;
using YGO7.Core.Interfaces;
using YGO7.Domain.Models;

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

        public async Task<IListResultDto<CompleteCardInformationDto>> GetAllCards()
        {
            var listaAll = await _service.GetAllCards();

            try
            {
                List<CompleteCardInformationDto> personViews =
                    Mapper.Map<List<CompleteCardInformation>, List<CompleteCardInformationDto>>(listaAll.Data.ToList());

                return new ListResultDto<CompleteCardInformationDto>(personViews);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }


        public async Task<ISingleResultDto<CompleteCardInformationDto>> GetById(string id)
        {
            var entity = await _service.GetById(id);
            try
            { 
                CompleteCardInformationDto dto =  Mapper.Map<CompleteCardInformation, CompleteCardInformationDto>(entity.Data);
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