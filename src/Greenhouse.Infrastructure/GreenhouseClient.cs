using System;
using System.Net;
using System.Threading.Tasks;
using CluedIn.Core.Providers;
using CluedIn.Crawling.Greenhouse.Core;
using Newtonsoft.Json;
using RestSharp;
using Microsoft.Extensions.Logging;
using RestSharp.Authenticators;
using CluedIn.Crawling.Greenhouse.Core.Models;
using System.Collections.Generic;

namespace CluedIn.Crawling.Greenhouse.Infrastructure
{
    // TODO - This class should act as a client to retrieve the data to be crawled.
    // It should provide the appropriate methods to get the data
    // according to the type of data source (e.g. for AD, GetUsers, GetRoles, etc.)
    // It can receive a IRestClient as a dependency to talk to a RestAPI endpoint.
    // This class should not contain crawling logic (i.e. in which order things are retrieved)
    public class GreenhouseClient
    {
        private const string BaseUri = "http://sample.com";

        private readonly ILogger<GreenhouseClient> log;

        private readonly IRestClient client;

        private readonly GreenhouseCrawlJobData _greenhouseCrawlJobData;

        public GreenhouseClient(ILogger<GreenhouseClient> log, GreenhouseCrawlJobData greenhouseCrawlJobData, IRestClient client) // TODO: pass on any extra dependencies
        {
            if (greenhouseCrawlJobData == null)
            {
                throw new ArgumentNullException(nameof(greenhouseCrawlJobData));
            }

            if (client == null)
            {
                throw new ArgumentNullException(nameof(client));
            }

            this.log = log ?? throw new ArgumentNullException(nameof(log));
            this.client = client ?? throw new ArgumentNullException(nameof(client));

            // TODO use info from greenhouseCrawlJobData to instantiate the connection
            client.BaseUrl = new Uri(BaseUri);
            client.AddDefaultParameter("api_key", greenhouseCrawlJobData.ApiKey, ParameterType.QueryString);
            _greenhouseCrawlJobData = greenhouseCrawlJobData;
        }

        public IEnumerable<Candidate> GetCandidates()
        {
            var client = new RestClient("https://harvest.greenhouse.io/v1");
            var request = new RestRequest("candidates", Method.GET);
            client.Authenticator = new HttpBasicAuthenticator(_greenhouseCrawlJobData.ApiKey, "");
            var response = client.Execute<List<Candidate>>(request);
            var content = response.Data;
            return content;
        }

        public AccountInformation GetAccountInformation()
        {
            //TODO - return some unique information about the remote data source
            // that uniquely identifies the account
            return new AccountInformation(_greenhouseCrawlJobData.ApiKey, "Greenhouse");
        }
    }
}
