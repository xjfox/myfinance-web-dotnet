using Microsoft.AspNetCore.Mvc;
using myfinance_web_netcore.Models.Domain;
using myfinance_web_netcore.UseCases.Interfaces;

namespace myfinance_web_netcore.Controllers
{
    [Route("[controller]")]
    public class TransacaoController : Controller
    {
        private readonly ILogger<TransacaoController> _logger;
        private readonly IConsultaTransacaoUseCase _consultaTransacaoUseCase;
        private readonly ICadastroTransacaoUseCase _cadastroTransacaoUseCase;
        private readonly IExcluiTransacaoUseCase _excluiTransacaoUseCase;
        private readonly IConsultaPlanoContaUseCase _consultaPlanoContaUseCase;

        public TransacaoController(
            ILogger<TransacaoController> logger,
            IConsultaTransacaoUseCase consultaTransacaoUseCase,
            ICadastroTransacaoUseCase cadastroTransacaoUseCase,
            IExcluiTransacaoUseCase excluiTransacaoUseCase,
            IConsultaPlanoContaUseCase consultaPlanoContaUseCase
        ) {
            _logger = logger;
            _consultaTransacaoUseCase = consultaTransacaoUseCase;
            _cadastroTransacaoUseCase = cadastroTransacaoUseCase;
            _excluiTransacaoUseCase = excluiTransacaoUseCase;
            _consultaPlanoContaUseCase = consultaPlanoContaUseCase;
        }

        [HttpGet]
        public IActionResult Index() {
            ViewBag.ListaTransacao = TransacaoModel.Build(
                _consultaTransacaoUseCase.ListarTransacao()
            );
            return View();
        }

        [HttpGet]
        [Route("Cadastro")]
        [Route("Cadastro/{id}")]
        public IActionResult Cadastro(int? id)
        {
            var transacaoModel = TransacaoModel.Build(
                id != null ? _consultaTransacaoUseCase.ObterTransacao((int)id) : null,
                _consultaPlanoContaUseCase.ListarPlanoConta()
            );
            return View(transacaoModel);
        }

        [HttpPost]
        [Route("Cadastro")]
        [Route("Cadastro/{id}")]
        public IActionResult Cadastro(TransacaoModel input)
        {
            _cadastroTransacaoUseCase.CadastrarTransacao(input.ToDomain());
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("Excluir/{id}")]
        public IActionResult Excluir(int id)
        {
            _excluiTransacaoUseCase.ExcluirTransacao(id);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View("Error!");
        }
    }
}

