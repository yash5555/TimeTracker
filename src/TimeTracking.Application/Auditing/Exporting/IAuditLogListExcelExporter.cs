using System.Collections.Generic;
using TimeTracking.Auditing.Dto;
using TimeTracking.Dto;

namespace TimeTracking.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);

        FileDto ExportToFile(List<EntityChangeListDto> entityChangeListDtos);
    }
}
