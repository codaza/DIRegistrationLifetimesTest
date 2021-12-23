using DIRegistrationLifetimesTest.Services.Interfaces;

namespace DIRegistrationLifetimesTest.Services
{
    public class TestService : ISingletonService, IScopedService, ITransientService
    {
        public string ServiceUniqueIdentifier { get; } = Guid.NewGuid().ToString();
    }
}
