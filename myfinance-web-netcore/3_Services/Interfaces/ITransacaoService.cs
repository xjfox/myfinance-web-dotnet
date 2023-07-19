using myfinance_web_netcore.Entities;

namespace myfinance_web_netcore.Services.Interfaces
{
    public interface ITransacaoService
    {
        List<Transacao> ListarTransacao(); 
        Transacao ObterTransacao(int Id); 
        void CadastrarTransacao(Transacao input);
        void ExcluirTranscao(int Id);
    }
}