using System;

namespace CommunityHospitalApi.Models
{
    public class Admission
    {
        /// <summary>
        /// Admission id
        /// </summary>
        public Guid AdmissionId { get; set; }
        /// <summary>
        /// Patient id
        /// </summary>
        public Guid PatientId { get; set; }
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
        /// Physician id
        /// </summary>
        public Guid PhysicianId { get; set; }
        /// <summary>
        /// Nursing unit id
        /// </summary>
        public string NursingUnitId { get; set; }
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
        public Patient Patient { get; set; }
        /// <summary>
        /// Physician record
        /// </summary>
        public Physician Physician { get; set; }
        /// <summary>
        /// Nursing unit record
        /// </summary>
        public NursingUnit NursingUnit { get; set; }
    }
}
