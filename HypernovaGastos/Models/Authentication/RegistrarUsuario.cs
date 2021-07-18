using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HypernovaGastos.Models.Authentication
{
    public class RegistrarUsuario
    {

        [Required(ErrorMessage = "El nombre de usuario es requerido")]
        public string Username { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "El Password es requerido")]
        public string Password { get; set; }
    }
}
