using System.Threading.Tasks;
using Abp.Application.Services;
using TimeTracking.MultiTenancy.Payments.PayPal.Dto;

namespace TimeTracking.MultiTenancy.Payments.PayPal
{
    public interface IPayPalPaymentAppService : IApplicationService
    {
        Task ConfirmPayment(long paymentId, string paypalOrderId);

        PayPalConfigurationDto GetConfiguration();
    }
}
