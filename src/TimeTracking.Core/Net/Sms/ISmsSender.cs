using System.Threading.Tasks;

namespace TimeTracking.Net.Sms
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}