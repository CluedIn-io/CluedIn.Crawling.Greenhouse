using Castle.Windsor;
using CluedIn.Core;
using CluedIn.Core.Providers;
using CluedIn.Crawling.Greenhouse.Infrastructure.Factories;
using Moq;

namespace CluedIn.Provider.Greenhouse.Unit.Test.GreenhouseProvider
{
    public abstract class GreenhouseProviderTest
    {
        protected readonly ProviderBase Sut;

        protected Mock<IGreenhouseClientFactory> NameClientFactory;
        protected Mock<IWindsorContainer> Container;

        protected GreenhouseProviderTest()
        {
            Container = new Mock<IWindsorContainer>();
            NameClientFactory = new Mock<IGreenhouseClientFactory>();
            var applicationContext = new ApplicationContext(Container.Object);
            Sut = new Greenhouse.GreenhouseProvider(applicationContext, NameClientFactory.Object);
        }
    }
}
