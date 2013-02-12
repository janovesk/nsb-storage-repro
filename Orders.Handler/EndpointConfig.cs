using NServiceBus;
using NServiceBus.Config;
using NServiceBus.Hosting.Profiles;

namespace Orders.Handler
{
    class EndpointConfig : IConfigureThisEndpoint, AsA_Publisher { }
    
    class ConfiguringTheDistributorWithTheFluentApi : INeedInitialization
    {
        public void Init()
        {
        }
    }

    class DistributorProfileHandler : IHandleProfile<Distributor>
    {
        public void ProfileActivated()
        {
            Configure.Instance.RunTimeoutManager();
        }
    }
}
