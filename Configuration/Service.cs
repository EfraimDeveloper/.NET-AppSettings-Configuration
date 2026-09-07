using Microsoft.Extensions.Options;

namespace Configuration
{
    public class Service
    {

        private readonly Appsetings _appsetings;

        public Service(Appsetings appsetings) {

            _appsetings = appsetings;
        }

        public void ShowAppsetings()
        {
            Console.WriteLine($"NameApp: {_appsetings.NameApp}");
            Console.WriteLine($"Version: {_appsetings.Version}");
            Console.WriteLine($"MaxNumberOfAttempts: {_appsetings.MaxNumberOfAttempts}");
            Console.WriteLine($"Developer: {_appsetings.Developer}");
        }


        
    }
}
