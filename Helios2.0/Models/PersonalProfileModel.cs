using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Helios2._0.Models
{
    public class PersonalProfileModel
    {
        public int Employee_profile_id { get; set; }
        public string Employee_name { get; set; }
        public string Prefered_name { get; set; }
        public string Nationality { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string Phone_number { get; set; }
        public string Email { get; set; }
        public string Mobile_number { get; set; }
        public string Image_url { get; set; }
        public string Network_id { get; set; }
        public int Created_by { get; set; }
        public DateTime Created_date { get; set; }
        public int Updated_by { get; set; }
        public DateTime Updated_date { get; set; }
        public bool Active_flag { get; set; }
    }
}