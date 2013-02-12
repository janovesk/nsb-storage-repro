using NServiceBus;
using NServiceBus.Hosting.Profiles;

namespace Orders.Handler
{
    public class EndpointConfig : IConfigureThisEndpoint, AsA_Publisher, IWantCustomInitialization
    {
        public void Init()
        {
             InitializeServiceBus();
        }

        public void InitializeServiceBus()
        {
            Configure.With()
                .Log4Net()
                .DefaultBuilder()
                .XmlSerializer()
                .RunTimeoutManager()
                .UnicastBus()
                .RavenSubscriptionStorage()
                .UseRavenTimeoutPersister()
                .DisableSecondLevelRetries();
        }

        public class WorkerProfileHandler : IHandleProfile<Worker>
        {
            public void ProfileActivated() { Configure.Instance.DisableTimeoutManager(); }
        }
    }
}
