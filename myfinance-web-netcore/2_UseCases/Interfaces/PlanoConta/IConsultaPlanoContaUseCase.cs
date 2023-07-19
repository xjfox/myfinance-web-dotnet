using myfinance_web_netcore.Entities;

namespace myfinance_web_netcore.UseCases.Interfaces
{
    public interface IConsultaPlanoContaUseCase
    {
        List<PlanoConta> ListarPlanoConta();
        PlanoConta ObterPlanoConta(int Id);
    }
}