﻿namespace Kinesia.Gestion.Services.Permission
{
    public interface IPermissionService
    {
        bool HasPermission(string key);
    }
}