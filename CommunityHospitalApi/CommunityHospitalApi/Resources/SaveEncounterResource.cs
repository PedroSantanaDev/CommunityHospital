using System;

namespace CommunityHospitalApi.Resources
{
    public class SaveEncounterResource
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
        /// Physician id
        /// </summary>
        public Guid PhysicianId { get; set; }
        /// <summary>
        /// Encounter date time
        /// </summary>
        public DateTime EncounterDateTime { get; set; }
        /// <summary>
        /// Notes
        /// </summary>
        public string Notes { get; set; }
    }
}
