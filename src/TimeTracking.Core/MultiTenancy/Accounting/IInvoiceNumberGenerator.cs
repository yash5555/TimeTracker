using System.Threading.Tasks;
using Abp.Dependency;

namespace TimeTracking.MultiTenancy.Accounting
{
    public interface IInvoiceNumberGenerator : ITransientDependency
    {
        Task<string> GetNewInvoiceNumber();
    }
}