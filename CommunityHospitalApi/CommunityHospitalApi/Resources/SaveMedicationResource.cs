using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityHospitalApi.Resources
{
    public class SaveMedicationResource
    {
        /// <summary>
        /// Medication description
        /// </summary>
        public string MedicationDescription { get; set; }
        /// <summary>
        /// Medication cost
        /// </summary>
        public decimal MedicationCost { get; set; }
        /// <summary>
        /// Medication package size
        /// </summary>
        public string PackageSize { get; set; }
        /// <summary>
        /// Medication strength
        /// </summary>
        public string Strength { get; set; }
        /// <summary>
        /// Medication sig
        /// </summary>
        public string Sig { get; set; }
        /// <summary>
        /// Medication units used year-to-date
        /// </summary>
        public int UnitsUsedYtd { get; set; }
        /// <summary>
        /// Medication last prescribed date
        /// </summary>
        public DateTime LastPrescribedDate { get; set; }
    }
}
