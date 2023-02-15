using System.Collections.Generic;
using Kinesia.Gestion.Authorization.Delegation;
using Kinesia.Gestion.Authorization.Users.Delegation.Dto;

namespace Kinesia.Gestion.Web.Areas.App.Models.Layout
{
    public class ActiveUserDelegationsComboboxViewModel
    {
        public IUserDelegationConfiguration UserDelegationConfiguration { get; set; }

        public List<UserDelegationDto> UserDelegations { get; set; }

        public string CssClass { get; set; }
    }
}
