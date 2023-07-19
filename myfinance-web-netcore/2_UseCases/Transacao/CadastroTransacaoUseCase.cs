using myfinance_web_netcore.Entities;
using myfinance_web_netcore.Services.Interfaces;
using myfinance_web_netcore.UseCases.Interfaces;

namespace myfinance_web_netcore.UseCases
{
    public class CadastroTransacaoUseCase : ICadastroTransacaoUseCase
    {
        private readonly ITransacaoService _transacaoService;

        public CadastroTransacaoUseCase(ITransacaoService transacaoService)
        {
            _transacaoService = transacaoService;
        }

        public void CadastrarTransacao(Transacao transacao)
        {
            _transacaoService.CadastrarTransacao(transacao);
        }
    }
}