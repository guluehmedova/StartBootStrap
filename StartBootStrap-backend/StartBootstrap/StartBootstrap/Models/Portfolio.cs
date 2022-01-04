using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StartBootstrap.Models
{
    public class Portfolio:BaseEntity
    {
        [StringLength(maximumLength:250)]
        public string Image { get; set; }
        [Required]
        [StringLength(maximumLength:50)]
        public string Title { get; set; }
        [StringLength(maximumLength:500)]
        public string Desc { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
