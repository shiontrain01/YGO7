using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MongoDB.Driver;
using YGO7.Application.Bases;
using YGO7.Application.Dtos;
using YGO7.Application.Interfaces;
using YGO7.Core.Interfaces;
using YGO7.Domain.Enums;
using YGO7.Domain.Models;

namespace YGO7.Application.Services
{
    public class CardAppService: AppService, ICardAppService
    {
        private readonly ICardService _service;

        public CardAppService( ICardService service, IMapper mapper)
            : base(mapper)
        {
            this._service = service;
        }

        public async Task<IListResultDto<CompleteCardInformationDto>> GetAll()
        {

            var listaAll = await _service.GetAll();

            try
            {
                List<CompleteCardInformationDto> personViews =
                    Mapper.Map<List<Card>, List<CompleteCardInformationDto>>(listaAll.Data.ToList());

                return new ListResultDto<CompleteCardInformationDto>(personViews);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }



            
        }

        public async Task<ISingleResultDto<CompleteCardInformationDto>> Get(string id)
        {
            var entity = _service.Get(id);
            var dto = Mapper.Map<CompleteCardInformationDto>(entity);
            return new SingleResultDto<CompleteCardInformationDto>(dto);

        }

        public async Task<ISingleResultDto<EntityDto>> Create(CompleteCardInformationDto dto)
        {
            
            // nao consigo mudar o dto de entra 
            // p dtp de emtodade é generico
            // entao posso mudar a entidade 
            //priceso saber um dado que diferete as cartas 
            // saber um dado q difere os tipos de monstros 
            
            var cardTypeOperation = 0;
            if (dto.CardType == CardTypeEnum.Monster)
            {
                 cardTypeOperation = 1;
            }
            if (dto.CardType == CardTypeEnum.Spell)
            {
                 cardTypeOperation = 2;
            }
            if (dto.CardType == CardTypeEnum.Trap)
            {
                 cardTypeOperation = 3;
            }


            var TipoCarta = cardTypeOperation switch
            {
                1 => "Case 1",
                2 => "Case 2",
                3 => "Case 3",
                _ => throw new NotImplementedException(),
            };

            var MonsterClassOperation = 0;
            if (dto.MonsterCardClass == MonsterCardClassEnum.Fusion)
            {
                MonsterClassOperation = 1;
            }
            if (dto.MonsterCardClass == MonsterCardClassEnum.Link)
            {
                MonsterClassOperation = 2;              }
            if (dto.MonsterCardClass == MonsterCardClassEnum.Synchro)
            {
                MonsterClassOperation = 3;
            }
            if (dto.MonsterCardClass == MonsterCardClassEnum.Xyz)
            {
                MonsterClassOperation = 4;
            }
              
              
            var ClasseDoMonstro = MonsterClassOperation switch
            {
                1 => "Case 1",
                2 => "Case 2",
                3 => "Case 3",
                4 => "Case 4",
                _ => throw new NotImplementedException(),
            };

            //  Console.WriteLine(teste);
          
            var evento = Mapper.Map<Card>(dto);
            var result =  await _service.Incluir(evento);

            var resultDto = new SingleResultDto<EntityDto>(result);
            resultDto.SetData(result, Mapper);

            return resultDto;
        }
        

        public async Task<ISingleResultDto<EntityDto>> Update(string id, CompleteCardInformationDto dto)
        {
            var evento = Mapper.Map<Card>(dto);

            var result = await _service.Editar(id, evento);

            var resultDto = new SingleResultDto<EntityDto>(result);
            resultDto.SetData(result, Mapper);

            return resultDto;
        }

        public async Task<ISingleResultDto<EntityDto>> Delete(string id)
        {
            var result = await _service.Excluir(id);

            var resultDto = new SingleResultDto<EntityDto>(result);
            resultDto.SetData(result, Mapper);

            return resultDto;
        }
    }
}