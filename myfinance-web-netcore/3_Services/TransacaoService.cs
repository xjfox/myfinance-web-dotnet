using myfinance_web_netcore.Adapters.Repositories.Interfaces;
using myfinance_web_netcore.Entities;
using myfinance_web_netcore.Services.Interfaces;

namespace myfinance_web_netcore.Services
{
    public class TransacaoService : ITransacaoService
    {
        private readonly ITransacaoRepository _transacaoRepository;

        public TransacaoService(ITransacaoRepository transacaoRepository)
        {
            _transacaoRepository = transacaoRepository;
        }

        public void CadastrarTransacao(Transacao transacao)
        {
            _transacaoRepository.Cadastrar(transacao);
        }

        public void ExcluirTranscao(int Id)
        {
            _transacaoRepository.Excluir(Id);
        }

        public List<Transacao> ListarTransacao()
        {
            return _transacaoRepository.ListarRegistros("PlanoConta");
        }

        public Transacao ObterTransacao(int Id)
        {
            return _transacaoRepository.ObterRegistro(Id);
        }

    }
}