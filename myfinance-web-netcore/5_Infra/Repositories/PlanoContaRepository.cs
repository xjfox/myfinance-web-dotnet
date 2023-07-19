using myfinance_web_netcore.Adapters.Repositories.Interfaces;
using myfinance_web_netcore.Infra.Repositories.Base;
using myfinance_web_netcore.Entities;


namespace myfinance_web_netcore.Infra.Repositories
{
    public class PlanoContaRepository : Repository<PlanoConta>, IPlanoContaRepository
    {
        public PlanoContaRepository(MyFinanceDbContext myFinanceDbContext) : base(myFinanceDbContext)
        {
        }
    }
}