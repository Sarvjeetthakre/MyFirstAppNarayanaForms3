using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstApp.Models
{
    public class Enquiry_Model
    {
        public string NAME { get; set; }
        public string EMAIL_ID { get; set; }
        
        public int Doctor_Id { get; set; }
        public string Doctor_Name { get; set; }
        public long CONTACT_NUMBER { get; set; }
        public string YOUR_QUERY { get; set; }
        public List<DoctoreModel> DoctoreModel { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifyBy { get; set; }
        public DateTime ModifyDate { get; set; }
    }
}