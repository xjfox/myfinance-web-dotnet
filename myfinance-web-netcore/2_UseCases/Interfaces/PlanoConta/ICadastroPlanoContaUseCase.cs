using myfinance_web_netcore.Entities;

namespace myfinance_web_netcore.UseCases.Interfaces
{
    public interface ICadastroPlanoContaUseCase
    {
        void CadastrarPlanoConta(PlanoConta input);
    }
}