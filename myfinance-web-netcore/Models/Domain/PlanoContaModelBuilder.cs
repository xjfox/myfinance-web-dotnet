using myfinance_web_netcore.Entities;
using myfinance_web_netcore.Models.Domain.Base;
using myfinance_web_netcore.Models.Domain.Interfaces;

namespace myfinance_web_netcore.Models.Domain
{
    public class PlanoContaModelBuilder : Builder<PlanoContaModel, PlanoConta, IPlanoContaModelBuilder>, IPlanoContaModelBuilder
    {
        public PlanoContaModelBuilder() : base()
        {
        }

        public override PlanoContaModelBuilder SetEntity(PlanoConta? planoConta)
        {
            if (planoConta != null)
            {
                _model.Id = planoConta.Id;
                _model.Descricao = planoConta.Descricao;
                _model.Tipo = planoConta.Tipo;
            }            
            return this;
        }
    }

}