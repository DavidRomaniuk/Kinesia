using System.Threading.Tasks;
using Abp.Application.Services;
using Kinesia.Gestion.Editions.Dto;
using Kinesia.Gestion.MultiTenancy.Dto;

namespace Kinesia.Gestion.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}