using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeoplePro.Models
{

    public class Department
    {
        public int Id { get; internal set; }

        [Required]
        [Display(Name = "Department Name")]
        public string DepartmentName { get; set; }

        [Required]
        [Display(Name = "Date Founded")]
        [DataType(DataType.Date)]
        public DateTime DateFounded { get; set; }

        [Required]
        [Display(Name = "Building")]
        [ForeignKey("Building")]
        public int BuildingId { get; set; }
        public virtual Building Building { get; set; }


    }


}
