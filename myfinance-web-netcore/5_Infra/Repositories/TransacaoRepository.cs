using myfinance_web_netcore.Adapters.Repositories.Interfaces;
using myfinance_web_netcore.Entities;
using myfinance_web_netcore.Infra.Repositories.Base;

namespace myfinance_web_netcore.Infra.Repositories
{
    public class TransacaoRepository : Repository<Transacao>, ITransacaoRepository
    {
        public TransacaoRepository(MyFinanceDbContext myFinanceDbContext) : base(myFinanceDbContext)
        {
        }        
    }
}