using CluedIn.Core;
using CluedIn.Crawling.Greenhouse.Core;

using ComponentHost;

namespace CluedIn.Crawling.Greenhouse
{
    [Component(GreenhouseConstants.CrawlerComponentName, "Crawlers", ComponentType.Service, Components.Server, Components.ContentExtractors, Isolation = ComponentIsolation.NotIsolated)]
    public class GreenhouseCrawlerComponent : CrawlerComponentBase
    {
        public GreenhouseCrawlerComponent([NotNull] ComponentInfo componentInfo)
            : base(componentInfo)
        {
        }
    }
}

