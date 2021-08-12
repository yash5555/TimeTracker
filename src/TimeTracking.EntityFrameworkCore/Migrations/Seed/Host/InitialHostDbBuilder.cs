using TimeTracking.EntityFrameworkCore;

namespace TimeTracking.Migrations.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly TimeTrackingDbContext _context;

        public InitialHostDbBuilder(TimeTrackingDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
