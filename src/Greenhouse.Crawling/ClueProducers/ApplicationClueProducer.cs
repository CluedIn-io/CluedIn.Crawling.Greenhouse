using System;
using CluedIn.Core;
using CluedIn.Core.Data;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Greenhouse.Core.Models;
using CluedIn.Crawling.Greenhouse.Infrastructure;
using Microsoft.Extensions.Logging;
using System.Linq;
using CluedIn.Crawling.Helpers;
using CluedIn.Crawling.Greenhouse.Vocabularies;

namespace CluedIn.Crawling.Greenhouse.ClueProducers
{
    public class ApplicationClueProducer : BaseClueProducer<Application>
    {
        private readonly IClueFactory _factory;
        private readonly ILogger<GreenhouseClient> _log;

        public ApplicationClueProducer([NotNull] IClueFactory factory, ILogger<GreenhouseClient> _log)
        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));
            this._log = _log;
        }

        protected override Clue MakeClueImpl(Application input, Guid id)
        {
            var clue = _factory.Create("/Application", input.Id.ToString(), id);
            var data = clue.Data.EntityData;

            var vocab = new ApplicationVocabulary();

            data.Properties[vocab.Status] = input.Status.PrintIfAvailable();
            data.Properties[vocab.RejectionReason] = input.RejectionReason.PrintIfAvailable();
            data.Properties[vocab.RejectionDetails] = input.RejectionDetails.PrintIfAvailable();
            data.Properties[vocab.RejectedAt] = input.RejectedAt.ToString().PrintIfAvailable();
            data.Properties[vocab.ProspectiveOffice] = input.ProspectiveOffice.PrintIfAvailable();
            data.Properties[vocab.ProspectiveDepartment] = input.ProspectiveDepartment.PrintIfAvailable();

            data.Properties[vocab.Prospect] = input.Prospect.PrintIfAvailable();
            data.Properties[vocab.Location] = input.Location.PrintIfAvailable();
            data.Properties[vocab.LastActivityAt] = input.LastActivityAt.PrintIfAvailable();
            data.Properties[vocab.CandidateId] = input.CandidateId.ToString().PrintIfAvailable();
            data.Properties[vocab.AppliedAt] = input.AppliedAt.PrintIfAvailable();


            if (!data.OutgoingEdges.Any())
            {
                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);
            }

            return clue;
        }
    }
}
