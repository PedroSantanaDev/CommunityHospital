﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityHospitalApi.Models
{
    public class Physician
    {
        /// <summary>
        /// Physician's id
        /// </summary>
        public Guid PhysicianId { get; set; }
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