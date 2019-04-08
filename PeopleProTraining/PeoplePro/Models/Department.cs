using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PeoplePro.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Department Name")]
        [StringLength(32, MinimumLength = 3)]
        public string DepartmentName { get; set; }
        
        [Required]
        [Display(Name = "Date Founded")]
        [DataType(DataType.Date)]
        public DateTime DateFounded { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Budget { get; set; }

        [Required]
        [ForeignKey("Building")]
        public int BuildingId { get; set; }
        public virtual Building Building { get; set; }

    }
}
