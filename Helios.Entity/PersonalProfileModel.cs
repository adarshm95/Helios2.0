using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Helios.Entity.Models
{
    public class PersonalProfileModel
    {
       public PersonalProfileModel()
        {
            Active_flag = true;
        }
        public int Employee_profile_id { get; set; }
        [DisplayName("EmployeeName")]
        public string Employee_name { get; set; }
        [DisplayName("PreferedName")]
        public string Prefered_name { get; set; }
        [DisplayName("Nationality")]
        public string Nationality { get; set; }
        [DisplayName("DOB")]
        public DateTime DOB { get; set; }
        [DisplayName("Gender")]
        public string Gender { get; set; }
        [DisplayName("PhoneNumber")]
        public string Phone_number { get; set; }
        [DisplayName("Email")]
        public string Email { get; set; }
        [DisplayName("MobileNumber")]
        public string Mobile_number { get; set; }
        [DisplayName("ImageURL")]
        public string Image_url { get; set; }
        [DisplayName("NetworkID")]
        public string Network_id { get; set; }
        [DisplayName("CreatedBY")]
        public int Created_by { get; set; }
        [DisplayName("CreatedDate")]
        public DateTime Created_date { get; set; }
        [DisplayName("UpdatedBY")]
        public int Updated_by { get; set; }
        [DisplayName("UpdatedDate")]
        public DateTime Updated_date { get; set; }
        [DisplayName("Activelag")]
        public bool Active_flag { get; set; }
    }
}