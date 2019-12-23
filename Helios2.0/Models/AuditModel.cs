using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Helios2._0.Models
{
    public class AuditModel
    {
        public int Log_id { get; set; }
        public DateTime Log_date { get; set; }
        public string Module_name { get; set; }
        public string Function_name { get; set; }
        public string Description { get; set; }
        public bool Is_error { get; set; }
    }
}