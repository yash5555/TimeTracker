using System.Collections.Generic;
using TimeTracking.Authorization.Users.Importing.Dto;
using Abp.Dependency;

namespace TimeTracking.Authorization.Users.Importing
{
    public interface IUserListExcelDataReader: ITransientDependency
    {
        List<ImportUserDto> GetUsersFromExcel(byte[] fileBytes);
    }
}
