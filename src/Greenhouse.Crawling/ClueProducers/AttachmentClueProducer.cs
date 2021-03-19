using System;
using CluedIn.Core;
using CluedIn.Core.Data;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Greenhouse.Core.Models;
using CluedIn.Crawling.Greenhouse.Infrastructure;
using Microsoft.Extensions.Logging;
using System.Linq;
using RestSharp;
using CluedIn.Core.Data.Parts;
using CluedIn.Core.Configuration;
using CluedIn.Core.IO;
using System.IO;

namespace CluedIn.Crawling.Greenhouse.ClueProducers
{
    public class AttachmentClueProducer : BaseClueProducer<Attachment>
    {
        private readonly IClueFactory _factory;
        private readonly ILogger<GreenhouseClient> _log;
        private readonly ApplicationContext _applicationContext;

        public AttachmentClueProducer([NotNull] IClueFactory factory, ILogger<GreenhouseClient> _log, ApplicationContext applicationContext)
        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));
            this._log = _log;
            this._applicationContext = applicationContext;
        }

        protected override Clue MakeClueImpl(Attachment input, Guid id)
        {
            var clue = _factory.Create(EntityType.Files.File, input.Url.ToString(), id);
            var data = clue.Data.EntityData;

            if (!string.IsNullOrEmpty(input.Filename))
            {
                data.Name = input.Filename;
            }

            if (!string.IsNullOrEmpty(input.Url))
            {
                data.Uri = new Uri(input.Url);
            }

            var download = new RestClient().DownloadData(new RestRequest(input.Url));
            this.Index(download, input.Filename, clue);

            if (!data.OutgoingEdges.Any())
            {
                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);
            }

            return clue;
        }


        public void Index(byte[] data, string filename, Clue clue)
        {
            if (data == null)
                throw new ArgumentNullException(nameof(data));

            if (clue == null)
                throw new ArgumentNullException(nameof(clue));

            if (!ConfigurationManagerEx.AppSettings.GetFlag("Crawl.InitialCrawl.FileIndexing", true))
                return;

            if (data.Length > Constants.MaxFileIndexingFileSize)
                return;

            using (var tempFile = new TemporaryFile(filename))
            {
                CreatePhysicalFile(data, tempFile);

                FileCrawlingUtility.IndexFile(tempFile, clue.Data, clue, null, _applicationContext);
            }
        }

        protected void CreatePhysicalFile(byte[] data, FileInfo info)
        {
            using (var stream = new MemoryStream(data))
            {
                using (var fs = new FileStream(info.FullName, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    stream.CopyTo(fs);
                }
            }
        }
    }
}
