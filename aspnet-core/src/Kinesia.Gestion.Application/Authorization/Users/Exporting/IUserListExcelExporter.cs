using System.Collections.Generic;
using Kinesia.Gestion.Authorization.Users.Dto;
using Kinesia.Gestion.Dto;

namespace Kinesia.Gestion.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}