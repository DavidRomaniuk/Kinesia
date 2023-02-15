using System.Collections.Generic;
using Abp;
using Kinesia.Gestion.Chat.Dto;
using Kinesia.Gestion.Dto;

namespace Kinesia.Gestion.Chat.Exporting
{
    public interface IChatMessageListExcelExporter
    {
        FileDto ExportToFile(UserIdentifier user, List<ChatMessageExportDto> messages);
    }
}
