using myfinance_web_netcore.Entities;

namespace myfinance_web_netcore.Services.Interfaces
{
    public interface IPlanoContaService
    {
        List<PlanoConta> ListarPlanoConta(); 
        PlanoConta ObterPlanoConta(int Id); 
        void CadastrarPlanoConta(PlanoConta input);
        void ExcluirPlanoConta(int Id);
    }
}