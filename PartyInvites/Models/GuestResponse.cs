using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your Email Address")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your Phone Number")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please specify whether you'll attend")]
        public bool? WillAttend { get; set; }
    }
}
