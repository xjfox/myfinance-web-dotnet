using myfinance_web_netcore.Entities;
using myfinance_web_netcore.Models.Domain.Interfaces.Base;

namespace myfinance_web_netcore.Models.Domain.Interfaces
{
    public interface ITransacaoModelBuilder : IBuilder<TransacaoModel, Transacao, ITransacaoModelBuilder>
    {
        ITransacaoModelBuilder SetItemPlanoConta(PlanoConta planoConta);
        ITransacaoModelBuilder SetPlanoContas(List<PlanoConta> planoContas);
    }
}