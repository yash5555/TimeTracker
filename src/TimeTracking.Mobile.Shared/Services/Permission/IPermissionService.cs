﻿namespace TimeTracking.Services.Permission
{
    public interface IPermissionService
    {
        bool HasPermission(string key);
    }
}