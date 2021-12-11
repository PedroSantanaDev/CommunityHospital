using System;

namespace CommunityHospitalApi.Resources
{
    public class AdmissionResource
    {
        /// <summary>
        /// Admission id
        /// </summary>
        public Guid AdmissionId { get; set; }
        /// <summary>
        /// Admission date
        /// </summary>
        public DateTime AdmissionDate { get; set; }
        /// <summary>
        /// Discharge date
        /// </summary>
        public DateTime DischargeDate { get; set; }
        /// <summary>
        /// Primary diagnosis
        /// </summary>
        public string PrimaryDiagnosis { get; set; }
        /// <summary>
        /// Secondary diagnosys
        /// </summary>
        public string SecondaryDiagnoses { get; set; }
        /// <summary>
        /// Room number
        /// </summary>
        public int RoomNumber { get; set; }
        /// <summary>
        /// Bed number
        /// </summary>
        public int BedNumber { get; set; }
        /// <summary>
        /// Patient record
        /// </summary>
        public PatientResource Patient { get; set; }
        /// <summary>
        /// Physician record
        /// </summary>
        public PhysicianResource Physician { get; set; }
        /// <summary>
        /// Nursing unit record
        /// </summary>
        public NursingUnitResource NursingUnit { get; set; }
    }
}
