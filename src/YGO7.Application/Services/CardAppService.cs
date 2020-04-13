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
using YGO7.Core.Models.Results;
using YGO7.Domain.Bases;
using YGO7.Domain.Enums;
using YGO7.Domain.Models;

namespace YGO7.Application.Services
{
    public class CardAppService : AppService, ICardAppService
    {
        private readonly ICardService _service;

        public CardAppService(ICardService service, IMapper mapper)
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
            

            // eu quero fazer com que o swtich case me de o tipo do monstro
            // tendo o tipo do monstro passado como parametro no switch case
            // eu quero que ele seja a chamada da função do mapeamento de mosntro
            // assim so vou ter uma função de mapeamento pra cada classe


            //var teste = MapeamentoClasseMonstro(dto);

            return await cardTypeOperation;
        }

        private async Task<ISingleResultDto<EntityDto>> MapeamentoTipoCartaSpell(CompleteCardInformationDto dto)
        {
            var evento = Mapper.Map<SpellCard>(dto);
            var result = await _service.Incluir(evento);

            var resultDto = new SingleResultDto<EntityDto>(result);
            resultDto.SetData(result, Mapper);
            return resultDto;
        }

        private async Task<ISingleResultDto<EntityDto>> MapeamentoTipoCartaTrap(CompleteCardInformationDto dto)
        {
            var evento = Mapper.Map<TrapCard>(dto);
            var result = await _service.Incluir(evento);

            var resultDto = new SingleResultDto<EntityDto>(result);
            resultDto.SetData(result, Mapper);
            return resultDto;
        }

        private async Task<ISingleResultDto<EntityDto>> MapeamentoClasseMonstro(CompleteCardInformationDto dto)
        {
            ISingleResult<Card> result;
            
            switch (dto.MonsterCardClass)
            {
                case MonsterCardClassEnum.Fusion:
                    result = await _service.Incluir(Mapper.Map<FusionMonster>(dto));
                    break;
                case MonsterCardClassEnum.Link:
                    result = await _service.Incluir(Mapper.Map<LinkMonster>(dto));
                    break;
                case MonsterCardClassEnum.Synchro:
                    result = await _service.Incluir(Mapper.Map<SynchroMonster>(dto));
                    break;
                case MonsterCardClassEnum.Xyz:
                    result = await _service.Incluir(Mapper.Map<XyzMonster>(dto));
                    break;
                default:
                    result = await _service.Incluir(Mapper.Map<Card>(dto));
                    break;
            }

            return SingleResultDto(result);
        }

        private ISingleResultDto<EntityDto> SingleResultDto(ISingleResult<Card> result)
        {
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