using System.Collections.Generic;
using TimeTracking.Authorization.Users.Dto;
using TimeTracking.Dto;

namespace TimeTracking.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}