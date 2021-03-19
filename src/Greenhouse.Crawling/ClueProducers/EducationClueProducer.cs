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

            //var vocab = new CandidateVocabulary();

            //if (!string.IsNullOrEmpty(input.FirstName) && !string.IsNullOrEmpty(input.LastName))
            //{
            //    data.Name = string.Format("{0}{1}", input.FirstName, input.LastName);
            //}

            ////if (!string.IsNullOrEmpty(input.Description))
            ////{
            ////    data.Description = input.Description;
            ////}

            //DateTimeOffset modifiedDate;
            //if (DateTimeOffset.TryParse(input.UpdatedAt.ToString(), out modifiedDate))
            //{
            //    data.ModifiedDate = modifiedDate;
            //}

            //DateTimeOffset createdDate;
            //if (DateTimeOffset.TryParse(input.CreatedAt.ToString(), out createdDate))
            //{
            //    data.CreatedDate = createdDate;
            //}

            //if (input.Tags != null)
            //    foreach (var tag in input.Tags)
            //    {
            //        data.Tags.Add(new Tag(tag.ToString()));
            //    }

            //if (input.SocialMediaAddresses != null)
            //    foreach (var socialMediaAddress in input.SocialMediaAddresses)
            //    {
            //        data.Aliases.Add(socialMediaAddress.ToString());
            //    }

            //if (input.PhoneNumbers != null)
            //    foreach (var phoneNumbers in input.PhoneNumbers)
            //    {
            //        data.Aliases.Add(phoneNumbers.ToString());
            //    }

            //if (input.EmailAddresses != null)
            //    foreach (var emailAddress in input.EmailAddresses)
            //    {
            //        var code = new EntityCode("/Candidate", "CluedIn", emailAddress.Value);
            //        data.Codes.Add(code);
            //    }

            //if (input.Educations != null)
            //    foreach (var education in input.Educations)
            //    {
            //        _factory.CreateOutgoingEntityReference(clue, "/School", EntityEdgeType.Attended, education, education.Id.ToString());
            //    }

            ////if (input.Employments != null)
            ////    foreach (var employment in input.Employments)
            ////    {
            ////        _factory.CreateOutgoingEntityReference(clue, "/Placement", EntityEdgeType.Attended, employment, employment.Id.ToString());
            ////    }

            //if (input.Company != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.Organization, EntityEdgeType.Attended, input, input.Company);

            //if (input.Attachments != null)
            //    foreach (var attachment in input.Attachments)
            //    {
            //        //You might need to parse this. 
            //        _factory.CreateOutgoingEntityReference(clue, EntityType.Files.File, EntityEdgeType.PartOf, attachment, attachment.Url.ToString());
            //    }

            //if (input.Applications != null)
            //    foreach (var application in input.ApplicationIds)
            //    {
            //        _factory.CreateOutgoingEntityReference(clue, "/Application", EntityEdgeType.For, application, application.ToString());
            //    }

            //if (input.Addresses != null)
            //    foreach (var address in input.Addresses)
            //    {
            //        _factory.CreateOutgoingEntityReference(clue, EntityType.Location, EntityEdgeType.For, address, address.Value.ToString());
            //    }

            //data.Properties[vocab.Title] = input.Title.PrintIfAvailable();
            //data.Properties[vocab.PhotoUrl] = input.PhotoUrl.PrintIfAvailable();
            //data.Properties[vocab.LastName] = input.LastName.PrintIfAvailable();
            //data.Properties[vocab.LastActivity] = input.LastActivity.ToString().PrintIfAvailable();
            //data.Properties[vocab.Coordinator] = input.Coordinator.PrintIfAvailable();
            //data.Properties[vocab.CanEmail] = input.CanEmail.PrintIfAvailable();

            //data.Properties[vocab.FirstName] = input.FirstName.PrintIfAvailable();


            if (!data.OutgoingEdges.Any())
            {
                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);
            }

            return clue;
        }
    }
}
