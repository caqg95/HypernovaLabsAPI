using HypernovaGastos.Models.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace HypernovaGastos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticateController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IConfiguration _configuration;



        public AuthenticateController(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IConfiguration configuration)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
        }

        [HttpPost("RegistrarUsuario")]
        public async Task<ActionResult<UserToken>> RegistrarUsuario([FromBody] RegistrarUsuario model)
        {
            var userExists = await _userManager.FindByNameAsync(model.Username);
            if (userExists != null)
                return (new BadRequestObjectResult(new { message = "Ya existe ese nombre de Usuario", currentDate = DateTime.Now }));



            var user = new ApplicationUser { UserName = model.Username, Email = model.Email, SecurityStamp = Guid.NewGuid().ToString() };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                return BuildToken(model, new List<string>());
            }
            else
            {
                return (new BadRequestObjectResult(new { message = "Se ha producido un error al registrar el Usuario", currentDate = DateTime.Now }));
            }
        }
        [HttpPost("Login")]
        public async Task<ActionResult<UserToken>> Login([FromBody] RegistrarUsuario userInfo)
        {
            var result = await _signInManager.PasswordSignInAsync(userInfo.Username, userInfo.Password, isPersistent: false, lockoutOnFailure: false);
            if (result.Succeeded)
            {
                var usuario = await _userManager.FindByNameAsync(userInfo.Username);
                var roles = await _userManager.GetRolesAsync(usuario);
                return BuildToken(userInfo, roles);
            }
            else
            {
                return BadRequest("Usuario o Contrasena Invalida");
            }
        }

        private UserToken BuildToken(RegistrarUsuario userInfo, IList<string> roles)
        {
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.UniqueName, userInfo.Username),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
             };

            foreach (var rol in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, rol));
            }

            var keyEnveiroment = _configuration["TokenKey"];
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(keyEnveiroment));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            // Tiempo de expiración del token. En nuestro caso lo hacemos de una hora.
            var expiration = DateTime.UtcNow.AddHours(2);

            JwtSecurityToken token = new JwtSecurityToken(
               issuer: null,
               audience: null,
               claims: claims,
               expires: expiration,
               signingCredentials: creds);

            return new UserToken()
            {
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                Expiration = expiration
            };
        }
    }
}
