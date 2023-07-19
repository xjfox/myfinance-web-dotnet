using myfinance_web_netcore.Entities;
using myfinance_web_netcore.Services.Interfaces;
using myfinance_web_netcore.UseCases.Interfaces;

namespace myfinance_web_netcore.UseCases
{
    public class CadastroPlanoContaUseCase : ICadastroPlanoContaUseCase
    {
        private readonly IPlanoContaService _planoContaService;

        public CadastroPlanoContaUseCase(IPlanoContaService planoContaService)
        {
            _planoContaService = planoContaService;
        }

        public void CadastrarPlanoConta(PlanoConta planoConta)
        {
            _planoContaService.CadastrarPlanoConta(planoConta);
        }
    }
}