using System.Collections.Generic;
using System.Linq;
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
    public class CardAppService: AppService, ICardAppService
    {
        private readonly ICardService _service;

        public CardAppService( ICardService service, IMapper mapper)
            : base(mapper)
        {
            this._service = service;
        }

        public async Task<IListResultDto<EffectMonsterDto>> GetAll()
        {

            var listaAll = await _service.GetAll();

            List<EffectMonsterDto> personViews =
                Mapper.Map<List<Card>, List<EffectMonsterDto>>(listaAll.Data.ToList());

            return new ListResultDto<EffectMonsterDto>(personViews);
        }

        public async Task<ISingleResultDto<EffectMonsterDto>> Get(string id)
        {
            var entity = _service.Get(id);
            var dto = Mapper.Map<EffectMonsterDto>(entity);
            return new SingleResultDto<EffectMonsterDto>(dto);

        }

        public async Task<ISingleResultDto<EntityDto>> Create(EffectMonsterDto dto)
        {
            var evento = Mapper.Map<Card>(dto);

            var result =  await _service.Incluir(evento);

            var resultDto = new SingleResultDto<EntityDto>(result);
            resultDto.SetData(result, Mapper);

            return resultDto;
        }

        public async Task<ISingleResultDto<EntityDto>> Update(string id, EffectMonsterDto dto)
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