using myfinance_web_netcore.Services.Interfaces;
using myfinance_web_netcore.UseCases.Interfaces;

namespace myfinance_web_netcore.UseCases
{
    public class ExcluiTransacaoUseCase : IExcluiTransacaoUseCase
    {
        private readonly ITransacaoService _transacaoService;

        public ExcluiTransacaoUseCase(ITransacaoService transacaoService)
        {
            _transacaoService = transacaoService;
        }

        public void ExcluirTransacao(int Id)
        {
            _transacaoService.ExcluirTranscao(Id);
        }

    }
}