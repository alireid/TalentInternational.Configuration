using Microsoft.Extensions.Hosting;
using TalentInternational.Configuration.AzureTableStorage;

namespace TalentInternational.Configuration.TestHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new HostBuilder()
                .ConfigureAppConfiguration((c, b) => b
                .AddAzureTableStorage(o =>
                {
                    o.EnvironmentNameEnvironmentVariableName = "";
                    o.ConfigurationKeys = new[]
                    {
                        "DoesntExist"
                    };
                }))
                .Build())
            {
            }
        }
    }
}