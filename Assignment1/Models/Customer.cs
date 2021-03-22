using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Assignment1.Models
{
    public class Customer
    {
       
        public int customerId { get; set; }

        [Required(ErrorMessage = "Please enter a customer first name.")]

        public string customerFirstName { get; set; }

        [Required(ErrorMessage = "Please enter a customer last name.")]

        public string customerLastName { get; set; }

        [Required(ErrorMessage = "Please enter a customer address.")]

        public string customerAddress { get; set; }

        [Required(ErrorMessage = "Please enter a customer city.")]

        public string customerCity { get; set; }

        [Required(ErrorMessage = "Please enter a customer state.")]

        public string customerState { get; set; }

        [Required(ErrorMessage = "Please enter a customer postal code.")]

        public string customerPostalCode { get; set; }

        [Required(ErrorMessage = "Please select a customer country.")]

        public string customerCountry { get; set; } //need to has a list of sample countries

     
        public string customerEmail { get; set; }



        public string customerPhone { get; set; }

        public string Slug => customerFirstName?.Replace(' ', '-').ToLower() + '-' + customerId;

    }
}

