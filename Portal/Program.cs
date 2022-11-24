using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System.Threading;

namespace Portal
{
    public class Program
    {
        public static int NUMBER_OF_VIRTUAL_MACHINES = 1;   

        public const string API_ADDRESS = "http://localhost:5001/api/time";

        #region Methods

        public static void Main(string[] args) => CreateWebHostBuilder(args).Build().Run();

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) => WebHost.CreateDefaultBuilder(args).UseStartup<Startup>();

        public static bool CheckIfThereIsThreadAvailable()
        {
            ThreadPool.GetAvailableThreads(workerThreads: out int wt, completionPortThreads: out int cp);

            return wt > 1;
        }

        #endregion Methods
    }
}