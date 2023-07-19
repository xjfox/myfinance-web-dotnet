using myfinance_web_netcore.Entities;

namespace myfinance_web_netcore.UseCases.Interfaces
{
    public interface IConsultaTransacaoUseCase
    {
        List<Transacao> ListarTransacao();
        Transacao ObterTransacao(int Id);
    }
}