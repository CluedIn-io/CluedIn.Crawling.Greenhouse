using CluedIn.Crawling.Greenhouse.Core;

namespace CluedIn.Crawling.Greenhouse
{
    public class GreenhouseCrawlerJobProcessor : GenericCrawlerTemplateJobProcessor<GreenhouseCrawlJobData>
    {
        public GreenhouseCrawlerJobProcessor(GreenhouseCrawlerComponent component) : base(component)
        {
        }
    }
}
