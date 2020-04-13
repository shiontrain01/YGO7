using System.Threading.Tasks;
using YGO7.Application.Bases;
using YGO7.Application.Dtos;

namespace YGO7.Application.Interfaces
{
    public interface ICardAppService : IAppService
    {
        Task<IListResultDto<EffectMonsterDto>> GetAll();
        Task<ISingleResultDto<EffectMonsterDto>> Get(string id);
        Task<ISingleResultDto<EntityDto>> Create(EffectMonsterDto dto);
        Task<ISingleResultDto<EntityDto>> Update(string id,EffectMonsterDto dto);
        Task<ISingleResultDto<EntityDto>> Delete(string id);
    }
}