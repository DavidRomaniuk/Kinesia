using System.Collections.Generic;
using Kinesia.Gestion.Authorization.Users.Importing.Dto;
using Kinesia.Gestion.Dto;

namespace Kinesia.Gestion.Authorization.Users.Importing
{
    public interface IInvalidUserExporter
    {
        FileDto ExportToFile(List<ImportUserDto> userListDtos);
    }
}
