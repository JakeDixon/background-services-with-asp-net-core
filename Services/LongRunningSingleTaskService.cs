using Microsoft.Extensions.Hosting;
using System.Threading;
using System.Threading.Tasks;

namespace BackgroundTasksASPNETCore.Services
{
    public class LongRunningSingleTaskService : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            // simulate logic by waiting for 2 seconds
            await Task.Delay(2000);
            // check if we should be exiting
            if (stoppingToken.IsCancellationRequested)
            {
                // clean up the state before exiting
                return;
            }
            // simulate more logic
            await Task.Delay(2000);
        }
    }
}
