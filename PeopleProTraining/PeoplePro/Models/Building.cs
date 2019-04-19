using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;


namespace PeoplePro.Models
{
    [Authorize(Users = "coulby")]
    public class Building
    {
        public int Id { get; internal set; }

        [Required]
        [Display(Name = "Building Name")]
        public string BuildingName { get; set; }


        [Required]
        [Display(Name = "Building Code")]
        public string BuildingAbrev { get; set; }

    }


}
