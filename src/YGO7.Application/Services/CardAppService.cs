using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using MongoDB.Driver;
using YGO7.Application.Bases;
using YGO7.Application.Dtos;
using YGO7.Application.Interfaces;
using YGO7.Core.Interfaces;
using YGO7.Domain.Models;

namespace YGO7.Application.Services
{
    public class CardAppService: AppService, ICardService
    {
        private readonly ICardService _service;
        private readonly IMongoCollection<Card> _card;
        

        public CardAppService( ICardService _service, IMapper _mapper)
            : base(_mapper)
        {
            this._service = _service;
        }

        public async Task<IListResultDto<EffectMonsterDto>> Listar()
        {
            return new ListResultDto<EffectMonsterDto>(new List<EffectMonsterDto>());
            
        }

       

        public async Task<ISingleResultDto<EffectMonsterDto>> GetCard(string id)
        {
            var entity = _card.Find<Card>(card => card.Id == id).FirstOrDefault();
            return new SingleResultDto<EffectMonsterDto>(entity);

        }

        public async Task<ISingleResultDto<EntityDto>> Create(EffectMonsterDto dto)
        {
            var evento = Mapper.Map<Card>(dto);

            var result =  _service.Create(evento);

            var resultDto = new SingleResultDto<EntityDto>(result);
            resultDto.SetData(result, Mapper);

            return resultDto;
        }

        public async Task<ISingleResultDto<EntityDto>> Update(EffectMonsterDto dto)
        {
            var evento = Mapper.Map<Card>(dto);

            var result = await _service.Update(evento);

            var resultDto = new SingleResultDto<EntityDto>(result);
            resultDto.SetData(result, Mapper);

            return resultDto;
        }

        public async Task<ISingleResultDto<EntityDto>> Excluir(int id)
        {
            var result = await _service.Excluir(id);

            var resultDto = new SingleResultDto<EntityDto>(result);
            resultDto.SetData(result, Mapper);

            return resultDto;
        }
    }
}