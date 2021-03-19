using System;
using CluedIn.Core;
using CluedIn.Core.Data;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Greenhouse.Core.Models;
using CluedIn.Crawling.Greenhouse.Infrastructure;
using Microsoft.Extensions.Logging;
using System.Linq;
using CluedIn.Crawling.Greenhouse.Vocabularies;
using CluedIn.Crawling.Helpers;

namespace CluedIn.Crawling.Greenhouse.ClueProducers
{
    public class EducationClueProducer : BaseClueProducer<Education>
    {
        private readonly IClueFactory _factory;
        private readonly ILogger<GreenhouseClient> _log;

        public EducationClueProducer([NotNull] IClueFactory factory, ILogger<GreenhouseClient> _log)
        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));
            this._log = _log;
        }

        protected override Clue MakeClueImpl(Education input, Guid id)
        {
            var clue = _factory.Create("/Education", input.Id.ToString(), id);
            var data = clue.Data.EntityData;

            var vocab = new EducationVocabulary();

            if (!string.IsNullOrEmpty(input.Degree))
            {
                data.Name = input.Degree;
            }

            data.Properties[vocab.Degree] = input.Degree.PrintIfAvailable();
            data.Properties[vocab.EndDate] = input.EndDate.PrintIfAvailable();
            data.Properties[vocab.Discipline] = input.Discipline.PrintIfAvailable();
            data.Properties[vocab.StartDate] = input.StartDate.PrintIfAvailable();
            data.Properties[vocab.SchoolName] = input.SchoolName.PrintIfAvailable();

            if (!data.OutgoingEdges.Any())
            {
                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);
            }

            return clue;
        }
    }
}
