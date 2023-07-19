using Microsoft.AspNetCore.Mvc;
using myfinance_web_netcore.Models.Domain;
using myfinance_web_netcore.UseCases.Interfaces;

namespace myfinance_web_netcore.Controllers
{
    [Route("[controller]")]
    public class PlanoContaController : Controller
    {
        private readonly ILogger<PlanoContaController> _logger;
        private readonly IConsultaPlanoContaUseCase _consultaPlanoContaUseCase;
        private readonly ICadastroPlanoContaUseCase _cadastroPlanoContaUseCase;
        private readonly IExcluiPlanoContaUseCase _excluiPlanoContaUseCase;

        public PlanoContaController(
            ILogger<PlanoContaController> logger,
            IConsultaPlanoContaUseCase consultaPlanoContaUseCase,
            ICadastroPlanoContaUseCase cadastroPlanoContaUseCase,
            IExcluiPlanoContaUseCase excluiPlanoContaUseCase
        ) {
            _logger = logger;
            _consultaPlanoContaUseCase = consultaPlanoContaUseCase;
            _cadastroPlanoContaUseCase = cadastroPlanoContaUseCase;
            _excluiPlanoContaUseCase = excluiPlanoContaUseCase;
        }

        [HttpGet]
        public IActionResult Index() {
            ViewBag.ListaPlanoConta = PlanoContaModel.Build(                  
                _consultaPlanoContaUseCase.ListarPlanoConta()
            );
            return View();
        }

        [HttpGet]
        [Route("Cadastro")]
        [Route("Cadastro/{id}")]
        public IActionResult Cadastro(int? id) {
            var planoContaModel = PlanoContaModel.Build(
                id != null
                ? _consultaPlanoContaUseCase.ObterPlanoConta((int)id)
                : null
            );
            return View(planoContaModel);
        }

        [HttpPost]
        [Route("Cadastro")]
        [Route("Cadastro/{id}")]
        public IActionResult Cadastro(PlanoContaModel input)
        {
            _cadastroPlanoContaUseCase.CadastrarPlanoConta(input.ToDomain());
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("Excluir/{id}")]
        public IActionResult Excluir(int id)
        {
            _excluiPlanoContaUseCase.ExcluirPlanoConta(id);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View("Error!");
        }
    }
}

