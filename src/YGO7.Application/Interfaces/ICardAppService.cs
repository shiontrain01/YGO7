using System.Threading.Tasks;
using YGO7.Application.Bases;
using YGO7.Application.Dtos;

namespace YGO7.Application.Interfaces
{
    public interface ICardAppService : IAppService
    {
        Task<IListResultDto<CompleteCardInformationDto>> GetAll();
        Task<ISingleResultDto<CompleteCardInformationDto>> Get(string id);
        Task<ISingleResultDto<EntityDto>> Create(CompleteCardInformationDto dto);
        Task<ISingleResultDto<EntityDto>> Update(string id,CompleteCardInformationDto dto);
        Task<ISingleResultDto<EntityDto>> Delete(string id);
    }
}