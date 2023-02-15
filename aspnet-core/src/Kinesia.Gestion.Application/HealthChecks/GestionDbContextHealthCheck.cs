using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Kinesia.Gestion.EntityFrameworkCore;

namespace Kinesia.Gestion.HealthChecks
{
    public class GestionDbContextHealthCheck : IHealthCheck
    {
        private readonly DatabaseCheckHelper _checkHelper;

        public GestionDbContextHealthCheck(DatabaseCheckHelper checkHelper)
        {
            _checkHelper = checkHelper;
        }

        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = new CancellationToken())
        {
            if (_checkHelper.Exist("db"))
            {
                return Task.FromResult(HealthCheckResult.Healthy("GestionDbContext connected to database."));
            }

            return Task.FromResult(HealthCheckResult.Unhealthy("GestionDbContext could not connect to database"));
        }
    }
}
