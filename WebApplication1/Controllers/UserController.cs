using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {      

        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetUser")]
        public Usuário Get()
        {
            var usuario = new Usuário();
            try
            {
                _logger.LogInformation("Rastreio - Entrou no Get");
                Convert.ToInt32("ERRO");

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, "ERRO");
            }

            return usuario;
        }
    }
}