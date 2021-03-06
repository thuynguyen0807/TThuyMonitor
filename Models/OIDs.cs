﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetworkMonitor.Models
{
    public class OIDs
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string OID { get; set; }

        [Required]
        public string Category { get; set; }
    }
}
