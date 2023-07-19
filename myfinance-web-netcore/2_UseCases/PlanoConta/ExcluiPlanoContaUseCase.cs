using myfinance_web_netcore.Services.Interfaces;
using myfinance_web_netcore.UseCases.Interfaces;

namespace myfinance_web_netcore.UseCases
{
    public class ExcluiPlanoContaUseCase : IExcluiPlanoContaUseCase
    {
        private readonly IPlanoContaService _planoContaService;

        public ExcluiPlanoContaUseCase(IPlanoContaService planoContaService)
        {
            _planoContaService = planoContaService;
        }

        public void ExcluirPlanoConta(int Id)
        {
            _planoContaService.ExcluirPlanoConta(Id);
        }

    }
}