using System;

namespace CommunityHospitalApi.Models
{
    public class Vendor
    {
        public Guid VendorId { get; set; }
        public string VendorName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public decimal PurchasesYtd { get; set; }
        public Guid ProvinceId { get; set; }
        public Province Province { get; set; }
    }
}
