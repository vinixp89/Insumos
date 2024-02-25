using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProdInsumos.Domain.Entities;
using ProdInsumos.Domain.Interfaces;
using ProdInsumos.Infra.Data.Repositories;

namespace ProdInsumos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        private readonly IFuncionarioRepository _funcionarioRepository;

        public FuncionarioController(IFuncionarioRepository funcionarioRepository) 
        {
            _funcionarioRepository = funcionarioRepository;
        
        }
        [HttpGet]

        public async Task<ActionResult<IEnumerable<Funcionario>>> GetFuncionario() 
        {

            return Ok(_funcionarioRepository.SelecionarTodosAsync());
        }
    }
}
