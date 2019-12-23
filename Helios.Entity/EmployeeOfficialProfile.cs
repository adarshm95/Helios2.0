using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Helios2._0.Models
{
    public class EmployeeOfficialProfile
    {
        public int Employee_official_profile_id { get; set; }
        public string Employee_id { get; set; }
        public int Employment_type_id { get; set; }
        public int Employee_role_id { get; set; }
        public int Department_Id { get; set; }
        public int Organization_unit_id { get; set; }
        public string Job_code { get; set; }
        public int Manager { get; set; }
        public int Hiring_manager { get; set; }
        public int Supervisor { get; set; }
        public int Hr_manager { get; set; }
        public DateTime Hiring_date { get; set; }
        public string Email_address { get; set; }
        public int Employee_proile_id { get; set; }
        public int Created_by { get; set; }
        public DateTime Created_Date { get; set; }
        public int  Last_updated_by { get; set; }
        public DateTime Last_updated_date { get; set; }
    }
}