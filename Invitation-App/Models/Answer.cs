using System;
using Microsoft.Build.Framework;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Xunit;
using System.Threading.Tasks;

namespace Invitation_App.Models
{
    public class Answer
    {
        [System.ComponentModel.DataAnnotations.Required (ErrorMessage ="Please Enter Your Name")]
        public string Name { get; set; }

        [System.ComponentModel.DataAnnotations.Required (ErrorMessage ="Please Enter Your SurName")]
        public string Surname { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Please Enter Your Email Adrres")]
        [EmailAddress]
        public string Email { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Please Enter Your Phone Number")]
        public string Phone { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Please Choose A n Answer")]
        public bool? YourAnswer { get; set; }
    }
}
