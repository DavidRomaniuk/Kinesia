using System.Collections.Generic;
using MvvmHelpers;
using Kinesia.Gestion.Models.NavigationMenu;

namespace Kinesia.Gestion.Services.Navigation
{
    public interface IMenuProvider
    {
        ObservableRangeCollection<NavigationMenuItem> GetAuthorizedMenuItems(Dictionary<string, string> grantedPermissions);
    }
}