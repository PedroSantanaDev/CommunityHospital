using CommunityHospitalApi.Models;
using System;

namespace CommunityHospitalApi.Resources
{
    public class PatientResource
    {
        /// <summary>
        /// Patiend id
        /// </summary>
        public Guid PatientId { get; set; }
        /// <summary>
        /// Patient first name
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Patient last name
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Patient gender
        /// </summary>
        public string Gender { get; set; }
        /// <summary>
        /// Patient birth date
        /// </summary>
        public DateTime BirthDate { get; set; }
        /// <summary>
        /// Patient street address
        /// </summary>
        public string StreetAddress { get; set; }
        /// <summary>
        /// Patient city
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// Patient postal code
        /// </summary>
        public string PostalCode { get; set; }
        /// <summary>
        /// Patient health card
        /// </summary>
        public string HealthCard { get; set; }
        /// <summary>
        /// Patient allergies
        /// </summary>
        public string Allergies { get; set; }
        /// <summary>
        /// Patient height
        /// </summary>
        public decimal PatientHeight { get; set; }
        /// <summary>
        /// patient Weight
        /// </summary>
        public decimal PatientWeight { get; set; }
        /// <summary>
        /// Patient Province
        /// </summary>
        public virtual ProvinceResource Province { get; set; }
    }
}
