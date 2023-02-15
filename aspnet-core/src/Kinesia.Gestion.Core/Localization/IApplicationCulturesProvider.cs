using System.Globalization;

namespace Kinesia.Gestion.Localization
{
    public interface IApplicationCulturesProvider
    {
        CultureInfo[] GetAllCultures();
    }
}