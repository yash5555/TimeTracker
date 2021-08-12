using System.Collections.Generic;
using Abp;
using TimeTracking.Chat.Dto;
using TimeTracking.Dto;

namespace TimeTracking.Chat.Exporting
{
    public interface IChatMessageListExcelExporter
    {
        FileDto ExportToFile(UserIdentifier user, List<ChatMessageExportDto> messages);
    }
}
