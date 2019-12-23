using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helios.Entity
{
    public class ProjectsModel
    {
        public int Project_id { get; set; }
        [DisplayName("ProjectParentID")]
        public int Project_parent_id { get; set; }
        [DisplayName("ProjectName")]
        public string Project_name { get; set; }
        [DisplayName("ProjectDescription")]
        public string Project_description { get; set; }
        [DisplayName("ProjectStartDate")]
        public DateTime Project_start_date { get; set; }
        [DisplayName("ProjectEndDate")]
        public DateTime Project_end_date { get; set; }
        [DisplayName("CreatedBy")]
        public int Created_by { get; set; }
        [DisplayName("CreatedDate")]
        public DateTime Created_date { get; set; }
        [DisplayName("ClientName")]
        public string Client_name { get; set; }
        [DisplayName("ActiveFlag")]
        public bool Active_flag { get; set; }
    }
}
