﻿using System;

namespace CommunityHospitalApi.Models
{
    public class Province
    {
        /// <summary>
        /// Province id
        /// </summary>
        public Guid ProvinceId { get; set; }
        /// <summary>
        /// Province code
        /// </summary>
        public string ProvinceCode { get; set; }
        /// <summary>
        /// Province name
        /// </summary>
        public string ProvinceName { get; set; }
    }
}
