using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TimeTracking.MultiTenancy.HostDashboard.Dto;

namespace TimeTracking.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}