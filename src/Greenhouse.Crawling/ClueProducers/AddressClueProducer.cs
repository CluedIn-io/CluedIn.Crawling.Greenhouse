using System;
using CluedIn.Core;
using CluedIn.Core.Data;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Greenhouse.Core.Models;
using CluedIn.Crawling.Greenhouse.Infrastructure;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace CluedIn.Crawling.Greenhouse.ClueProducers
{
    public class AddressClueProducer : BaseClueProducer<Address>
    {
        private readonly IClueFactory _factory;
        private readonly ILogger<GreenhouseClient> _log;

        public AddressClueProducer([NotNull] IClueFactory factory, ILogger<GreenhouseClient> _log)
        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));
            this._log = _log;
        }

        protected override Clue MakeClueImpl(Address input, Guid id)
        {
            var clue = _factory.Create(EntityType.Location, input.Value.ToString(), id);
            var data = clue.Data.EntityData;

            if (!string.IsNullOrEmpty(input.Value))
            {
                data.Name = input.Value;
            }

            if (!data.OutgoingEdges.Any())
            {
                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);
            }

            return clue;
        }
    }
}
