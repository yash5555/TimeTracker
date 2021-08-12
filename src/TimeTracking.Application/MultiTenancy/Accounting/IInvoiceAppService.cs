using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using TimeTracking.MultiTenancy.Accounting.Dto;

namespace TimeTracking.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
