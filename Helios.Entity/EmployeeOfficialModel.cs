using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helios.Entity.Models
{
   public class EmployeeOfficialModel
    {
        public int Employee_official_profile_id { get; set; }
        [DisplayName("Employee Id")]
        public string Employee_id { get; set; }
        [DisplayName("Employee Type")]
        public int Employee_type_id { get; set; }
        public string Employee_Type_name { get; set; }
        [DisplayName("Employee Role")]
        public int Employee_role_id { get; set; }
        public string Role_name { get; set; }
        [DisplayName("Department")]
        public int Department_Id { get; set; }
        public string Department_name { get; set; }
        [DisplayName("Organization Unit")]
        public int Organization_unit_id { get; set; }
        public string Organization_unit_name{ get; set; }
         [DisplayName("Job Code")]
        public string Job_code { get; set; }
        public int Manager { get; set; }
        public string Manager_Name { get; set; }
        [DisplayName("Hiring Manager")]
        public int Hiring_manager { get; set; }
        public string Hiring_Manager_Name { get; set; }
        public int Supervisor { get; set; }
        public string supervisor_Name { get; set; }
        [DisplayName("HR Manager")]
        public int Hr_manager { get; set; }
        public string HR_Manager_Name { get; set; }
        [DisplayName("Hiring Date")]
        public DateTime Hiring_date { get; set; }
        [DisplayName("Email")]
        public string Email_address { get; set; }
        [DisplayName("Employee Profile Id")]
        public int Employee_proile_id { get; set; }
        [DisplayName("Created By")]
        public int Created_by { get; set; }
        [DisplayName("Created Date")]
        public DateTime Created_Date { get; set; }
        [DisplayName("Last Updated By")]
        public int Last_updated_by { get; set; }
        [DisplayName("Last Updated Date")]
        public DateTime Last_updated_date { get; set; }
        [DisplayName("Active Flag")]
        public bool Active_flag { get; set; }
      
    }
}
