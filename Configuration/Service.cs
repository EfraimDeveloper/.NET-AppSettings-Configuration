using Microsoft.Extensions.Options;

namespace Configuration
{
    public class Service
    {

        private readonly Appsetings _appsetings;
        private readonly ILogger<Service> _logger;

        public Service(IOptions<Appsetings> appsetings, ILogger<Service> logger) {

            _appsetings = appsetings.Value;
            _logger = logger;
        }

        public void ShowAppsetings()
        {
            _logger.LogInformation("Showing AppSettings:");
            Console.WriteLine($"NameApp: {_appsetings.NameApp}");
            Console.WriteLine($"Version: {_appsetings.Version}");
            Console.WriteLine($"MaxNumberOfAttempts: {_appsetings.MaxNumberOfAttempts}");
            Console.WriteLine($"Developer: {_appsetings.Developer}");
        }


        
    }
}
