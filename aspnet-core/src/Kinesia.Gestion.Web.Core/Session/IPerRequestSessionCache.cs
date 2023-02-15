using System.Threading.Tasks;
using Kinesia.Gestion.Sessions.Dto;

namespace Kinesia.Gestion.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
