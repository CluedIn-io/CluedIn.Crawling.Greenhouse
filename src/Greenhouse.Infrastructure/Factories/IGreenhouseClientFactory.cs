using CluedIn.Crawling.Greenhouse.Core;

namespace CluedIn.Crawling.Greenhouse.Infrastructure.Factories
{
    public interface IGreenhouseClientFactory
    {
        GreenhouseClient CreateNew(GreenhouseCrawlJobData greenhouseCrawlJobData);
    }
}
