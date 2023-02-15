using System.Threading.Tasks;

namespace Kinesia.Gestion.Security
{
    public interface IPasswordComplexitySettingStore
    {
        Task<PasswordComplexitySetting> GetSettingsAsync();
    }
}
