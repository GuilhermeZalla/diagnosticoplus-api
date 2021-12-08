using APITCC2021.Models.Api;
using APITCC2021.Repositories;
using APITCC2021.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace APITCC2021.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : Controller
    {
        private readonly UsuariosRepo _repo;
        private readonly JwtService _jwtService;
        public UsuariosController(UsuariosRepo repo, JwtService jwtService)
        {
            _repo = repo;
            _jwtService = jwtService;
        }

        //Rota de criação de usuários
        [HttpPost("cadastro")]
        public async Task<ActionResult<dynamic>> SignUp([FromBody] UsuarioForm user)
        {
            try
            {
                var resp = await _repo.Create(user);

                return Ok(resp);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        //Rota de login e geração do token
        [HttpPost("login")]
        public async Task<ActionResult<dynamic>> LogIn([FromBody] Login model)
        {
            try
            {
                var user = await _repo.ValidateLogIn(model.Email, model.Password);

                if (user == null) { return NotFound(new { message = "Usuário ou senha inválidos." }); }

                var token = _jwtService.GenerateToken(user);
                return new
                {
                    token = token
                };
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        //Encontrar usuário logado com JWT
        [HttpGet("me")]
        [Authorize]
        public async Task<ActionResult<dynamic>> Me()
        {
            try
            {
                var userId = int.Parse(this.User.Claims.First(i => i.Type == "UserId").Value);

                var user = await _repo.FindUserById(userId);
                if (user == null)
                {
                    return BadRequest();
                }
                user.Password = null;
                return Ok(user);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
