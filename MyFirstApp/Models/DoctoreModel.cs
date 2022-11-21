using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstApp.Models
{
    public class DoctoreModel
    {
        public int Doctor_Id{ get; set; }
        public  string Doctor_Name  { get; set; }
        public int DOCTOR_QUALIFICATION_ID { get; set; }
        public string DOCTOR_QUALIFICATION_Name { get; set; }
        public  string Specialist { get; set; }
        public String City { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public  string Contact2 { get; set; }
        public DateTime Time { get; set; }
        public string Experience { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifyBy { get; set; }
        public DateTime ModifyDate { get; set; }
        public string IsActive { get; set; }

    }
}