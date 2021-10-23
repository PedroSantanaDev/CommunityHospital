namespace CommunityHospitalApi.Resources
{
    public class SaveNursingUnitResource
    {
        /// <summary>
        /// Nursing unit id
        /// </summary>
        public string NursingUnitId { get; set; }
        /// <summary>
        /// Nursing unit specialty
        /// </summary>
        public string Specialty { get; set; }
        /// <summary>
        /// Nursing unit manager's firt name
        /// </summary>
        public string ManagerFirstName { get; set; }
        /// <summary>
        /// Nursing unit manager's last name
        /// </summary>
        public string ManagerLastName { get; set; }
        /// <summary>
        /// Nursing unit number of  beds
        /// </summary>
        public int Beds { get; set; }
        /// <summary>
        /// Nursing unit extension
        /// </summary>
        public int Extension { get; set; }
    }
}
