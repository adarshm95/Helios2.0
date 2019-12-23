using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helios.Entity
{
    public class ClientModel
    {
        public int Client_Id { get; set; }
        [Required(ErrorMessage = "Client Name is Mandatory")]
        [DisplayName("Client Name")]
        public string Client_Name { get; set; }
        public string Description { get; set; }
        [DisplayName("Active On")]
        [Required(ErrorMessage = "Active On Field Should not be Empty")]
        public DateTime ActiveOn { get; set; }
        [DisplayName("Created By")]
        [Required(ErrorMessage = "Created By Field Should not be Empty")]
        public int CreatedBy { get; set; }
        [DisplayName("Created Date")]
        [Required(ErrorMessage = "Created Date Field Should not be Empty")]
        public DateTime CreatedDate { get; set; }
        [DisplayName("Updated By")]
        [Required(ErrorMessage = "Updated By is Mandatory")]
        public int UpdatedBy { get; set; }
        [DisplayName("Updated Date")]

        public DateTime UpdatedDate { get; set; }
        [DisplayName("Active Flag")]
        public bool ActiveFlag { get; set; }
    }
}
