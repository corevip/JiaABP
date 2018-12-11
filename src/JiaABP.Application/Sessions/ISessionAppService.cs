using System.Threading.Tasks;
using Abp.Application.Services;
using JiaABP.Sessions.Dto;

namespace JiaABP.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
