using System.Threading.Tasks;
using YGO7.Domain.Models;

namespace YGO7.Core.Interfaces
{
    public interface IGetCardService
    {
        Task<ISingleResult<CompleteCardInformation>> GetById(string id);

    }
}