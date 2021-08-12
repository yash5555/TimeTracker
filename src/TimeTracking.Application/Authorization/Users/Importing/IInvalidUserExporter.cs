using System.Collections.Generic;
using TimeTracking.Authorization.Users.Importing.Dto;
using TimeTracking.Dto;

namespace TimeTracking.Authorization.Users.Importing
{
    public interface IInvalidUserExporter
    {
        FileDto ExportToFile(List<ImportUserDto> userListDtos);
    }
}
