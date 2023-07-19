using myfinance_web_netcore.Entities;
using myfinance_web_netcore.Services.Interfaces;
using myfinance_web_netcore.UseCases.Interfaces;

namespace myfinance_web_netcore.UseCases
{
    public class ConsultaPlanoContaUseCase : IConsultaPlanoContaUseCase
    {
        private readonly IPlanoContaService _planoContaService;

        public ConsultaPlanoContaUseCase(IPlanoContaService planoContaService)
        {
            _planoContaService = planoContaService;
        }
        
        public List<PlanoConta> ListarPlanoConta()
        {
            return _planoContaService.ListarPlanoConta();
        }

        public PlanoConta ObterPlanoConta(int Id)
        {
            return _planoContaService.ObterPlanoConta(Id);
        }
    }
}