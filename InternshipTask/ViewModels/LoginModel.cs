using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternshipTask.ViewModels
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Missing email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Missing password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
