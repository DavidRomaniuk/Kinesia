using System.Collections.Generic;
using Kinesia.Gestion.Authorization.Users.Importing.Dto;
using Abp.Dependency;

namespace Kinesia.Gestion.Authorization.Users.Importing
{
    public interface IUserListExcelDataReader: ITransientDependency
    {
        List<ImportUserDto> GetUsersFromExcel(byte[] fileBytes);
    }
}
