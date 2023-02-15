using System.Collections.Generic;
using Kinesia.Gestion.Auditing.Dto;
using Kinesia.Gestion.Dto;

namespace Kinesia.Gestion.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);

        FileDto ExportToFile(List<EntityChangeListDto> entityChangeListDtos);
    }
}
