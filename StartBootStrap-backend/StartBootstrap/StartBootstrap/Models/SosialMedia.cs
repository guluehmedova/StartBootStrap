using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StartBootstrap.Models
{
    public class SosialMedia:BaseEntity
    {
        [Required]
        [StringLength(maximumLength:50)]
        public string Name { get; set; }
        public string RedirectUrl { get; set; }
        public string Icon { get; set; }
    }
}
