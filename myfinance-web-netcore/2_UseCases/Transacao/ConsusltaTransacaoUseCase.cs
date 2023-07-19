using myfinance_web_netcore.Entities;
using myfinance_web_netcore.Services.Interfaces;
using myfinance_web_netcore.UseCases.Interfaces;

namespace myfinance_web_netcore.UseCases
{
    public class ConsultaTransacaoUseCase : IConsultaTransacaoUseCase
    {
        private readonly ITransacaoService _transacaoService;

        public ConsultaTransacaoUseCase(ITransacaoService transacaoService)
        {
            _transacaoService = transacaoService;
        }
        
        public List<Transacao> ListarTransacao()
        {
            return _transacaoService.ListarTransacao();
        }

        public Transacao ObterTransacao(int Id)
        {
            return _transacaoService.ObterTransacao(Id);
        }
    }
}