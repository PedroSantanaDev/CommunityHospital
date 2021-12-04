using System;

namespace CommunityHospitalApi.Resources
{
    public class VendorResource
    {
        /// <summary>
        /// Vendor id
        /// </summary>
        public Guid VendorId { get; set; }
        /// <summary>
        /// Vendor name
        /// </summary>
        public string VendorName { get; set; }
        /// <summary>
        /// Vendor street Address
        /// </summary>
        public string StreetAddress { get; set; }
        /// <summary>
        /// Vendor city
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// Vendor postal code
        /// </summary>
        public string PostalCode { get; set; }
        /// <summary>
        /// Vendor contact first name
        /// </summary>
        public string ContactFirstName { get; set; }
        /// <summary>
        /// Vendor contact last name
        /// </summary>
        public string ContactLastName { get; set; }
        /// <summary>
        /// Vendor purchases year to date
        /// </summary>
        public decimal PurchasesYtd { get; set; }
        /// <summary>
        /// vendor province
        /// </summary>
        public virtual ProvinceResource Province { get; set; }
    }
}
