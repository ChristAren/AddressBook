using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBook.Models
{
    public class Overview
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "The {0} must be at least {2} and no more than {1} characters long.", MinimumLength = 2)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "The {0} must be at least {2} and no more than {1} characters long.", MinimumLength = 2)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Email")]
        [StringLength(30, ErrorMessage = "The {0} must be at least {2} and no more than {1} characters long.", MinimumLength = 2)]
        public string PersonalEmail { get; set; }

        [Display(Name = "Work Email")]
        [StringLength(30, ErrorMessage = "The {0} must be at least {2} and no more than {1} characters long.", MinimumLength = 2)]
        public string WorkEmail { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Mobile Phone")]
        public string MobilePhone { get; set; }

        [Phone]
        [Display(Name = "Work Phone")]
        public string WorkPhone { get; set; }

        [Phone]
        [Display(Name = "Home Phone")]
        public string HomePhone { get; set; }

        [Display(Name = "Address 1")]
        [StringLength(30, ErrorMessage = "The {0} must be at least {2} and no more than {1} characters long.", MinimumLength = 2)]
        public string Address1 { get; set; }

        [Display(Name = "Address 2")]
        [StringLength(30, ErrorMessage = "The {0} must be at least {2} and no more than {1} characters long.", MinimumLength = 2)]
        public string Address2 { get; set; }

        [Required]
        [Display(Name = "City")]
        [StringLength(30, ErrorMessage = "The {0} must be at least {2} and no more than {1} characters long.", MinimumLength = 2)]
        public string City { get; set; }

        [Required]
        [Display(Name = "State")]
        [StringLength(30, ErrorMessage = "The {0} must be at least {2} and no more than {1} characters long.", MinimumLength = 2)]
        public string State { get; set; }

        [Display(Name = "Zip Code")]
        [StringLength(10, ErrorMessage = "The {0} must be at least {2} and no more than {1} characters long.", MinimumLength = 2)]
        public string Zip { get; set; }

        [Display(Name = "Company Name")]
        [StringLength(30, ErrorMessage = "The {0} must be at least {2} and no more than {1} characters long.", MinimumLength = 2)]
        public string Company { get; set; }

        [Display(Name = "Fax Number")]
        [StringLength(15, ErrorMessage = "The {0} must be at least {2} and no more than {1} characters long.", MinimumLength = 6)]
        public string Fax { get; set; }
    }
}
