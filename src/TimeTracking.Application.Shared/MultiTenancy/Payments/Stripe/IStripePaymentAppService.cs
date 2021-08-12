using System.Threading.Tasks;
using Abp.Application.Services;
using TimeTracking.MultiTenancy.Payments.Dto;
using TimeTracking.MultiTenancy.Payments.Stripe.Dto;

namespace TimeTracking.MultiTenancy.Payments.Stripe
{
    public interface IStripePaymentAppService : IApplicationService
    {
        Task ConfirmPayment(StripeConfirmPaymentInput input);

        StripeConfigurationDto GetConfiguration();

        Task<SubscriptionPaymentDto> GetPaymentAsync(StripeGetPaymentInput input);

        Task<string> CreatePaymentSession(StripeCreatePaymentSessionInput input);
    }
}