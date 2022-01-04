﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StartBootstrap.Models
{
    public class Setting:BaseEntity
    {
        [Required]
        [StringLength(maximumLength:50)]
        public string Key { get; set; }
        [StringLength(maximumLength:500)]
        public string Value { get; set; }
    }
}
