using HypernovaGastos.Models;
using HypernovaGastos.Models.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HypernovaGastos.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> userManager;
        public UsuariosController(UserManager<ApplicationUser> userManage)
        {
            this.userManager = userManage;
        }

        [HttpGet("ObtenerUsuarios/")]
        public IActionResult ObtenerGastos()
        {
            var users = userManager.Users;
            return Ok(users);
        }
    }
}
