using System.Collections.Generic;

using CluedIn.Core.Crawling;
using CluedIn.Crawling.Greenhouse.Core;
using CluedIn.Crawling.Greenhouse.Infrastructure.Factories;

namespace CluedIn.Crawling.Greenhouse
{
    public class GreenhouseCrawler : ICrawlerDataGenerator
    {
        private readonly IGreenhouseClientFactory clientFactory;
        public GreenhouseCrawler(IGreenhouseClientFactory clientFactory)
        {
            this.clientFactory = clientFactory;
        }

        public IEnumerable<object> GetData(CrawlJobData jobData)
        {
            if (!(jobData is GreenhouseCrawlJobData greenhousecrawlJobData))
            {
                yield break;
            }

            var client = clientFactory.CreateNew(greenhousecrawlJobData);

            foreach(var candidate in client.GetCandidates())
            { 
                yield return candidate.Educations;
                yield return candidate.Attachments;
                yield return candidate.Applications;
                yield return candidate.Addresses;

                yield return candidate;
            }
            //retrieve data from provider and yield objects
            
        }       
    }
}
