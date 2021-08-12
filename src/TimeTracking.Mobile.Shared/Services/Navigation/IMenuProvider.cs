using System.Collections.Generic;
using MvvmHelpers;
using TimeTracking.Models.NavigationMenu;

namespace TimeTracking.Services.Navigation
{
    public interface IMenuProvider
    {
        ObservableRangeCollection<NavigationMenuItem> GetAuthorizedMenuItems(Dictionary<string, string> grantedPermissions);
    }
}