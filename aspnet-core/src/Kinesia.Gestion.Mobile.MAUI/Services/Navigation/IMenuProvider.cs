using Kinesia.Gestion.Models.NavigationMenu;

namespace Kinesia.Gestion.Services.Navigation
{
    public interface IMenuProvider
    {
        List<NavigationMenuItem> GetAuthorizedMenuItems(Dictionary<string, string> grantedPermissions);
    }
}