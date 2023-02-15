﻿using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Kinesia.Gestion.Authorization.Permissions.Dto;
using Kinesia.Gestion.Web.Areas.App.Models.Common;

namespace Kinesia.Gestion.Web.Areas.App.Models.Users
{
    public class UsersViewModel : IPermissionsEditViewModel
    {
        public string FilterText { get; set; }

        public List<ComboboxItemDto> Roles { get; set; }

        public bool OnlyLockedUsers { get; set; }

        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}
