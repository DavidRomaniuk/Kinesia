using System.Collections.Generic;
using System.Threading.Tasks;
using Abp;
using Kinesia.Gestion.Dto;

namespace Kinesia.Gestion.Gdpr
{
    public interface IUserCollectedDataProvider
    {
        Task<List<FileDto>> GetFiles(UserIdentifier user);
    }
}
