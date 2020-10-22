using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoMVC.Models
{
    public class ContactModel
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string EMail { get; set; }
        public string Query { get; set; }

        public override string ToString()
        {
         return  string.Format("Hello {0}, We have received your query as per details:Name: {0}, Phone: {1}, EMail:{2}, Query:{3} ",
                this.Name, this.Phone,this.EMail, this.Query);
        }
    }
}