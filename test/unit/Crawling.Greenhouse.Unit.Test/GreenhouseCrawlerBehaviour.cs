using CluedIn.Core.Crawling;
using CluedIn.Crawling;
using CluedIn.Crawling.Greenhouse;
using CluedIn.Crawling.Greenhouse.Infrastructure.Factories;
using Moq;
using Shouldly;
using Xunit;

namespace Crawling.Greenhouse.Unit.Test
{
    public class GreenhouseCrawlerBehaviour
    {
        private readonly ICrawlerDataGenerator _sut;

        public GreenhouseCrawlerBehaviour()
        {
            var nameClientFactory = new Mock<IGreenhouseClientFactory>();

            _sut = new GreenhouseCrawler(nameClientFactory.Object);
        }

        [Fact]
        public void GetDataReturnsData()
        {
            var jobData = new CrawlJobData();

            _sut.GetData(jobData)
                .ShouldNotBeNull();
        }
    }
}
