using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoMVC.Helpers
{
    public class SBValidator: ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            bool isItValid = false; 
            if (value!=null)
            {
                if (value.ToString() == "1234")
                {
                    isItValid = false;
                }
                else
                {
                    isItValid = true;
                }
            }
            return isItValid;

        }
    }
}