using myfinance_web_netcore.Adapters.Repositories.Interfaces;
using myfinance_web_netcore.Entities;
using myfinance_web_netcore.Services.Interfaces;

namespace myfinance_web_netcore.Services
{
    public class PlanoContaService : IPlanoContaService
    {
        private readonly IPlanoContaRepository _planoContaRepository;
        
        public PlanoContaService(IPlanoContaRepository planoContaRepository)
        {
            _planoContaRepository = planoContaRepository;
        }

        public void CadastrarPlanoConta(PlanoConta planoConta)
        {
            _planoContaRepository.Cadastrar(planoConta);
        }

        public void ExcluirPlanoConta(int Id)
        {
            _planoContaRepository.Excluir(Id);
        }


        public List<PlanoConta> ListarPlanoConta()
        {
            return _planoContaRepository.ListarRegistros();
        }

        public PlanoConta ObterPlanoConta(int Id)
        {
            return _planoContaRepository.ObterRegistro(Id);
        }
    }
}