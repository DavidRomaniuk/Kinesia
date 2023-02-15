using System.Threading.Tasks;
using Abp.Application.Services;
using Kinesia.Gestion.Sessions.Dto;

namespace Kinesia.Gestion.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
