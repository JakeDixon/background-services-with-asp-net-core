using Microsoft.Extensions.Hosting;
using System.Threading;
using System.Threading.Tasks;

namespace BackgroundTasksASPNETCore.Services
{
    public class ShortRunningSingleTaskService : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            // simulate quick logic
            await Task.Delay(200);
        }
    }
}
