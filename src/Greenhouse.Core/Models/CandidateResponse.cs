using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Greenhouse.Core.Models
{
    public class Recruiter
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("id")]
        public object Id { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("employee_id")]
        public object EmployeeId { get; set; }
    }

    public class PhoneNumber
    {

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class KeyedCustomFields
    {

        [JsonProperty("salary_expectations")]
        public object SalaryExpectations { get; set; }
    }

    public class EmailAddress
    {

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class Education
    {

        [JsonProperty("start_date")]
        public DateTime? StartDate { get; set; }

        [JsonProperty("school_name")]
        public string SchoolName { get; set; }

        [JsonProperty("id")]
        public object Id { get; set; }

        [JsonProperty("end_date")]
        public DateTime? EndDate { get; set; }

        [JsonProperty("discipline")]
        public string Discipline { get; set; }

        [JsonProperty("degree")]
        public string Degree { get; set; }
    }

    public class CustomFields
    {

        [JsonProperty("salary_expectations")]
        public object SalaryExpectations { get; set; }
    }

    public class Coordinator
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("id")]
        public object Id { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("employee_id")]
        public object EmployeeId { get; set; }
    }

    public class Attachment
    {

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }
    }

    public class Source
    {

        [JsonProperty("public_name")]
        public string PublicName { get; set; }

        [JsonProperty("id")]
        public object Id { get; set; }
    }

    public class ProspectDetail
    {

        [JsonProperty("prospect_stage")]
        public object ProspectStage { get; set; }

        [JsonProperty("prospect_pool")]
        public object ProspectPool { get; set; }

        [JsonProperty("prospect_owner")]
        public object ProspectOwner { get; set; }
    }

    public class Job
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public object Id { get; set; }
    }

    public class CurrentStage
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public object Id { get; set; }
    }

    public class CreditedTo
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("id")]
        public object Id { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("employee_id")]
        public object EmployeeId { get; set; }
    }

    public class Application
    {

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("source")]
        public Source Source { get; set; }

        [JsonProperty("rejection_reason")]
        public object RejectionReason { get; set; }

        [JsonProperty("rejection_details")]
        public object RejectionDetails { get; set; }

        [JsonProperty("rejected_at")]
        public object RejectedAt { get; set; }

        [JsonProperty("prospective_office")]
        public object ProspectiveOffice { get; set; }

        [JsonProperty("prospective_department")]
        public object ProspectiveDepartment { get; set; }

        [JsonProperty("prospect_detail")]
        public ProspectDetail ProspectDetail { get; set; }

        [JsonProperty("prospect")]
        public bool Prospect { get; set; }

        [JsonProperty("location")]
        public object Location { get; set; }

        [JsonProperty("last_activity_at")]
        public DateTime LastActivityAt { get; set; }

        [JsonProperty("keyed_custom_fields")]
        public KeyedCustomFields KeyedCustomFields { get; set; }

        [JsonProperty("jobs")]
        public List<Job> Jobs { get; set; }

        [JsonProperty("id")]
        public object Id { get; set; }

        [JsonProperty("custom_fields")]
        public CustomFields CustomFields { get; set; }

        [JsonProperty("current_stage")]
        public CurrentStage CurrentStage { get; set; }

        [JsonProperty("credited_to")]
        public CreditedTo CreditedTo { get; set; }

        [JsonProperty("candidate_id")]
        public object CandidateId { get; set; }

        [JsonProperty("applied_at")]
        public DateTime AppliedAt { get; set; }

        [JsonProperty("answers")]
        public List<object> Answers { get; set; }
    }

    public class Address
    {

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class Candidate
    {

        [JsonProperty("website_addresses")]
        public List<object> WebsiteAddresses { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("tags")]
        public List<object> Tags { get; set; }

        [JsonProperty("social_media_addresses")]
        public List<object> SocialMediaAddresses { get; set; }

        [JsonProperty("recruiter")]
        public Recruiter Recruiter { get; set; }

        [JsonProperty("photo_url")]
        public object PhotoUrl { get; set; }

        [JsonProperty("phone_numbers")]
        public List<PhoneNumber> PhoneNumbers { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("last_activity")]
        public DateTime LastActivity { get; set; }

        [JsonProperty("keyed_custom_fields")]
        public KeyedCustomFields KeyedCustomFields { get; set; }

        [JsonProperty("is_private")]
        public bool IsPrivate { get; set; }

        [JsonProperty("id")]
        public object Id { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("employments")]
        public List<object> Employments { get; set; }

        [JsonProperty("email_addresses")]
        public List<EmailAddress> EmailAddresses { get; set; }

        [JsonProperty("educations")]
        public List<Education> Educations { get; set; }

        [JsonProperty("custom_fields")]
        public CustomFields CustomFields { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("coordinator")]
        public Coordinator Coordinator { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("can_email")]
        public bool CanEmail { get; set; }

        [JsonProperty("attachments")]
        public List<Attachment> Attachments { get; set; }

        [JsonProperty("applications")]
        public List<Application> Applications { get; set; }

        [JsonProperty("application_ids")]
        public List<object> ApplicationIds { get; set; }

        [JsonProperty("addresses")]
        public List<Address> Addresses { get; set; }
    }


}
