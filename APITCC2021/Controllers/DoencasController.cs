using APITCC2021.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace APITCC2021.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoencasController : ControllerBase
    {
        private readonly DoencasRepo _repo;
        public DoencasController(DoencasRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<dynamic>> GetAll()
        {
            var resp = await _repo.GetDoencas();
            return Ok(resp);
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<dynamic>> GetById(int id)
        {
            var resp = await _repo.GetDoencaById(id);
            return Ok(resp);
        }
    }
}
