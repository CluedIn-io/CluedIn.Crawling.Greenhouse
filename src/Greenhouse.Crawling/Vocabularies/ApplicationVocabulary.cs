using System;
using System.Collections.Generic;
using System.Text;
using CluedIn.Core.Data.Vocabularies;


namespace CluedIn.Crawling.Greenhouse.Vocabularies
{
    public class ApplicationVocabulary : SimpleVocabulary
    {
        public ApplicationVocabulary()
        {
            VocabularyName = "Greenhouse Application"; // TODO: Set value
            KeyPrefix = "greenhouse.Application"; // TODO: Set value
            KeySeparator = ".";
            Grouping = "/Application"; // TODO: Check value

            AddGroup("Greenhouse Details", group =>
            {
                RejectionReason = group.Add(new VocabularyKey("RejectionReason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey("Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RejectionDetails = group.Add(new VocabularyKey("RejectionDetails", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RejectedAt = group.Add(new VocabularyKey("RejectedAt", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProspectiveOffice = group.Add(new VocabularyKey("ProspectiveOffice", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProspectiveDepartment = group.Add(new VocabularyKey("ProspectiveDepartment", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Prospect = group.Add(new VocabularyKey("Prospect", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Location = group.Add(new VocabularyKey("Location", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastActivityAt = group.Add(new VocabularyKey("LastActivityAt", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CandidateId = group.Add(new VocabularyKey("CandidateId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AppliedAt = group.Add(new VocabularyKey("AppliedAt", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

        }

        public VocabularyKey RejectionReason { get; internal set; }
        public VocabularyKey Status { get; internal set; }
        public VocabularyKey RejectionDetails { get; internal set; }
        public VocabularyKey RejectedAt { get; internal set; }
        public VocabularyKey ProspectiveOffice { get; internal set; }
        public VocabularyKey ProspectiveDepartment { get; internal set; }
        public VocabularyKey Prospect { get; internal set; }
        public VocabularyKey Location { get; internal set; }
        public VocabularyKey LastActivityAt { get; internal set; }
        public VocabularyKey CandidateId { get; internal set; }
        public VocabularyKey AppliedAt { get; internal set; }
    }
}


