using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models
{
    public class Incident
    {
        
        public int incidentId { get; set; }
        [Required(ErrorMessage ="Please select a customer")]
        public string incidentCustomer { get; set; }


        [Required(ErrorMessage = "Please select a product")]
        public string incidentProduct { get; set; }

        public Technician technician { get; set; }


        [Required(ErrorMessage = "Please enter a incident title")]
      
        public string incidentTitle { get; set; }

        [Required(ErrorMessage = "Please enter a description.")]
        public string incidentDes { get; set; }

        public int? incidentTech { get; set; }
        public DateTime DateOpened { get; set; }

        public DateTime DateClosed { get; set; }


        public string Slug => incidentTitle?.Replace(' ', '-').ToLower()+ '-' + incidentId.ToString() ;
        
    }
}
