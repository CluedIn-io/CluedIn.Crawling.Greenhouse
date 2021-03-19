using System;
using System.Collections.Generic;
using System.Text;
using CluedIn.Core.Data.Vocabularies;


namespace CluedIn.Crawling.Greenhouse.Vocabularies
{
    public class CandidateVocabulary : SimpleVocabulary
    {
        public CandidateVocabulary()
        {
            VocabularyName = "Greenhouse Candidate"; // TODO: Set value
            KeyPrefix = "greenhouse.Candidate"; // TODO: Set value
            KeySeparator = ".";
            Grouping = "/Candidate"; // TODO: Check value

            AddGroup("Greenhouse Details", group =>
            {
                Title = group.Add(new VocabularyKey("Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhotoUrl = group.Add(new VocabularyKey("PhotoUrl", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastName = group.Add(new VocabularyKey("LastName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastActivity = group.Add(new VocabularyKey("LastActivity", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Coordinator = group.Add(new VocabularyKey("Coordinator", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CanEmail = group.Add(new VocabularyKey("CanEmail", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                FirstName = group.Add(new VocabularyKey("FirstName", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
            });

            this.AddMapping(this.FirstName, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInPerson.FirstName);
            this.AddMapping(this.LastName, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInPerson.LastName);
        }

        public VocabularyKey Title { get; internal set; }
        public VocabularyKey PhotoUrl { get; internal set; }
        public VocabularyKey LastName { get; internal set; }
        public VocabularyKey LastActivity { get; internal set; }
        public VocabularyKey Coordinator { get; internal set; }
        public VocabularyKey CanEmail { get; internal set; }
        public VocabularyKey FirstName { get; internal set; }
    }
}


