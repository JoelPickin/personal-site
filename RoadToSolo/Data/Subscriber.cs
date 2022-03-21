using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RoadToSolo.Data
{
    public class Subscriber
    {
        [Required(ErrorMessage = "Your name is required.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Your email is required.")]
        [EmailAddress(ErrorMessage = "Not a valid e-mail address. Try again!")]
        public string Email { get; set; }
    }
}
