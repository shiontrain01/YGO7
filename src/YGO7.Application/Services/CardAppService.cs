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
using YGO7.Domain.Bases;
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

            ;
            var cardTypeOperation = dto.CardType switch
            {
                CardTypeEnum.Monster => MapeamentoClasseMonstro(dto),
                CardTypeEnum.Spell => MapeamentoTipoCartaSpell(dto),
                CardTypeEnum.Trap => MapeamentoTipoCartaTrap(dto),
                _ => throw new NotImplementedException()
            };
            
            
            async Task<ISingleResultDto<EntityDto>> MapeamentoTipoCartaSpell(CompleteCardInformationDto dto)
            {
                var evento = Mapper.Map<SpellCard>(dto);
                var result =  await _service.Incluir(evento);

                var resultDto = new SingleResultDto<EntityDto>(result);
                resultDto.SetData(result, Mapper);
                return resultDto;
            }
            async Task<ISingleResultDto<EntityDto>> MapeamentoTipoCartaTrap(CompleteCardInformationDto dto)
            {
                var evento = Mapper.Map<TrapCard>(dto);
                var result =  await _service.Incluir(evento);

                var resultDto = new SingleResultDto<EntityDto>(result);
                resultDto.SetData(result, Mapper);
                return resultDto;
            }
            

             var MonsterClassOperation = dto.MonsterCardClass switch
             {
                 MonsterCardClassEnum.Fusion => 1,
                 MonsterCardClassEnum.Link => 2,
                 MonsterCardClassEnum.Synchro => 3,
                 MonsterCardClassEnum.Xyz => 4,
                 _ => 0
             };
             
            // eu quero fazer com que o swtich case me de o tipo do monstro
            // tendo o tipo do monstro passado como parametro no switch case
            // eu quero que ele seja a chamada da função do mapeamento de mosntro
            // assim so vou ter uma função de mapeamento pra cada classe
            async Task<ISingleResultDto<EntityDto>> MapeamentoClasseMonstro(CompleteCardInformationDto dto)
            {
                Task<ISingleResultDto<EntityDto>> MonsterClassOperation;
                switch (dto.MonsterCardClass)
                {
                    case  MonsterCardClassEnum.Fusion:
                        var entidade = Mapper.Map<FusionMonster>(dto);
                        cardTypeOperation = MapeamentoClasseMonstroSummon(dto,entidade);
                        break;
                    case  MonsterCardClassEnum.Link:
                        var entidade = Mapper.Map<LinkMonster>(dto);
                        cardTypeOperation = MapeamentoClasseMonstroSummon(dto,entidade);
                        break;
                    case  MonsterCardClassEnum.Synchro:
                        var entidade = Mapper.Map<SynchroMonster>(dto);
                        cardTypeOperation = MapeamentoClasseMonstroSummon(dto,entidade);
                        break;
                    case  MonsterCardClassEnum.Xyz:
                        var entidade = Mapper.Map<XyzMonster>(dto);
                        cardTypeOperation = MapeamentoClasseMonstroSummon(dto,entidade);
                        break;
                    default:
                        throw new NotImplementedException();
                }
                var evento = Mapper.Map<Card>(dto);
                var result =  await _service.Incluir(evento);

                var resultDto = new SingleResultDto<EntityDto>(result);
                resultDto.SetData(result, Mapper);
                return resultDto;
            }

            async Task<ISingleResultDto<EntityDto>> MapeamentoClasseMonstroSummon(CompleteCardInformationDto dto,Entity entidade )
            {
                var evento = Mapper.Map<entidade>(dto);
                var result =  await _service.Incluir(evento);

                var resultDto = new SingleResultDto<EntityDto>(result);
                resultDto.SetData(result, Mapper);
                return resultDto;
            }

            return await cardTypeOperation;
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