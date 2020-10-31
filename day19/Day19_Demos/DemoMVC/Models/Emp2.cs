﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using DemoMVC.Helpers;
namespace DemoMVC.Models
{
    [MetadataType(typeof(Extra_Info_About_Emp))]
    public partial class Emp
    { 
    
    }

    public class Extra_Info_About_Emp
    {
        [Required(ErrorMessage = "No is must")]
        [Range(1, 100, ErrorMessage = "No must be between 1 to 100")]
        public int No { get; set; }

        [SBValidator(ErrorMessage = "1234 is not a valid Name")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Address is must")]
        public string Address { get; set; }
    }
}