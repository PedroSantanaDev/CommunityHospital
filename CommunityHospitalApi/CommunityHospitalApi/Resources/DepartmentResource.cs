using System;

namespace CommunityHospitalApi.Resources
{
    public class DepartmentResource
    {
        /// <summary>
        /// Department id
        /// </summary>
        public Guid DepartmentId { get; set; }
        /// <summary>
        /// Department name
        /// </summary>
        public string DepartmentName { get; set; }
        /// <summary>
        /// Manager first name
        /// </summary>
        public string ManagerFirstName { get; set; }
        /// <summary>
        /// Manager last name
        /// </summary>
        public string ManagerLastName { get; set; }
        /// <summary>
        /// Date created
        /// </summary>
        public DateTime DateCreated { get; set; }
    }
}
