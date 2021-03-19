using System;
using System.Collections.Generic;
using System.Text;
using CluedIn.Core.Data.Vocabularies;


namespace CluedIn.Crawling.Greenhouse.Vocabularies
{
    public class EducationVocabulary : SimpleVocabulary
    {
        public EducationVocabulary()
        {
            VocabularyName = "Greenhouse Education"; // TODO: Set value
            KeyPrefix = "greenhouse.Education"; // TODO: Set value
            KeySeparator = ".";
            Grouping = "/Education"; // TODO: Check value

            AddGroup("Greenhouse Details", group =>
            {
                Degree = group.Add(new VocabularyKey("Degree", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EndDate = group.Add(new VocabularyKey("EndDate", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Discipline = group.Add(new VocabularyKey("Discipline", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SchoolName = group.Add(new VocabularyKey("SchoolName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartDate = group.Add(new VocabularyKey("StartDate", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

        }
     
        public VocabularyKey Degree { get; internal set; }
        public VocabularyKey EndDate { get; internal set; }
        public VocabularyKey Discipline { get; internal set; }
        public VocabularyKey SchoolName { get; internal set; }
        public VocabularyKey StartDate { get; internal set; }
    }
}


