using Microsoft.Extensions.Hosting;
using System.Threading;
using System.Threading.Tasks;

namespace BackgroundTasksASPNETCore.Services
{
    public class LifeTimeTaskService : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while(!stoppingToken.IsCancellationRequested)
            {
                // do some logic, for this example lets just wait for 2 seconds
                await Task.Delay(2000);
            }
        }
    }
}
