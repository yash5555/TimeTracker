using System.Collections.Generic;
using System.Threading.Tasks;
using Abp;
using TimeTracking.Dto;

namespace TimeTracking.Gdpr
{
    public interface IUserCollectedDataProvider
    {
        Task<List<FileDto>> GetFiles(UserIdentifier user);
    }
}
