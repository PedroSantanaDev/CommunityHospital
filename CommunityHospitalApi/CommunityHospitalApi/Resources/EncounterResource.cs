using System;

namespace CommunityHospitalApi.Resources
{
    public class EncounterResource
    {
        /// <summary>
        /// Encounter id
        /// </summary>
        public Guid EncounterId { get; set; }
        /// <summary>
        /// Patient id
        /// </summary>
        public Guid PatientId { get; set; }
        /// <summary>
        /// Encounter date and time
        /// </summary>
        public DateTime EncounterDateTime { get; set; }
        /// <summary>
        /// Notes
        /// </summary>
        public string Notes { get; set; }
        /// <summary>
        /// Encounter patient
        /// </summary>
        public PatientResource Patient { get; set; }
        /// <summary>
        /// Physician record
        /// </summary>
        public PhysicianResource Physician { get; set; }
    }
}
