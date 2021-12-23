using DIRegistrationLifetimesTest.Services.Interfaces;

namespace DIRegistrationLifetimesTest.Services
{
    public class DatabaseService
    {
        private readonly ISingletonService _singleton;
        private readonly IScopedService _scoped;
        private readonly ITransientService _transient;

        public DatabaseService(
            ISingletonService singleton,
            IScopedService scoped,
            ITransientService transient)
        {
            _singleton = singleton;
            _scoped = scoped;
            _transient = transient;
        }

        public void Save()
        {
            Console.WriteLine("\n||||||||| DatabaseService |||||||||\n");

            Console.WriteLine($"Singleton UID:\t\t{_singleton.ServiceUniqueIdentifier}");
            Console.WriteLine($"Scoped UID:\t\t{_scoped.ServiceUniqueIdentifier}");
            Console.WriteLine($"Transient UID:\t\t{_transient.ServiceUniqueIdentifier}");
        }
    }
}
