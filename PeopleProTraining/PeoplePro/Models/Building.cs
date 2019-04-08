using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PeoplePro.Models
{
    public class Building
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Building Name")]
        [StringLength(32, MinimumLength = 5)]
        public string BuildingName { get; set; }

        [Required]
        [Display(Name = "Building Code")]
        [StringLength(5, MinimumLength = 3)]
        public string BuildingAbrev { get; set; }
    }
}
