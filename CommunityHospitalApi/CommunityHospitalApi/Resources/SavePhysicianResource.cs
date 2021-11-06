namespace CommunityHospitalApi.Resources
{
    public class SavePhysicianResource
    {
        /// <summary>
        /// Physician's first name
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Physician's  last name
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Physician's specialty
        /// </summary>
        public string Specialty { get; set; }
        /// <summary>
        ///Physician's Phone
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// Physician's OHIP registration
        /// </summary>
        public int OHIPRegistration { get; set; }
    }
}
