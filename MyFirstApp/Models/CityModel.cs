using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstApp.Models
{
    public class CityModel
    {
        public int City_Id { get; set; }
        public int State_Id { get; set; }
        public string City_Name { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifyBy { get; set; }
        public DateTime ModifyDate { get; set; }
        public string IsActive { get; set; }
    }
}