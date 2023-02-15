using System.Threading.Tasks;
using Abp.Domain.Policies;

namespace Kinesia.Gestion.Authorization.Users
{
    public interface IUserPolicy : IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}
