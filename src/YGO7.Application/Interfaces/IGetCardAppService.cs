using System.Threading.Tasks;
using YGO7.Application.Dtos;

namespace YGO7.Application.Interfaces
{
    public interface IGetCardAppService : IAppService
    {
        Task<ISingleResultDto<CompleteCardInformationDto>> GetById(string id);
        
        Task<IListResultDto<CompleteCardInformationDto>> GetAllCards();

    }
}