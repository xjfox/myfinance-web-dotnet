using Microsoft.AspNetCore.Mvc.Rendering;
using myfinance_web_netcore.Entities;
using myfinance_web_netcore.Models.Domain.Base;
using myfinance_web_netcore.Models.Domain.Interfaces;


namespace myfinance_web_netcore.Models.Domain
{
    public class TransacaoModelBuilder : Builder<TransacaoModel, Transacao, ITransacaoModelBuilder>, ITransacaoModelBuilder
    {
        private readonly IPlanoContaModelBuilder _planoContaModelBuilder;
        
        public TransacaoModelBuilder(IPlanoContaModelBuilder planoContaModelBuilder) : base()
        {
            _planoContaModelBuilder = planoContaModelBuilder;
        }

        public override ITransacaoModelBuilder SetEntity(Transacao? transacao)
        {
            if (transacao != null)
            {
                _model.Id = transacao.Id;
                _model.Data = transacao.Data;
                _model.Historico = transacao.Historico;
                _model.Valor = transacao.Valor;
                _model.PlanoContaId = transacao.PlanoContaId;

                if (transacao.PlanoConta != null)
                {
                    SetItemPlanoConta(transacao.PlanoConta);
                }
            } else {
                _model.Data = System.DateTime.Today;
            }        

            return this;
        }

        public ITransacaoModelBuilder SetItemPlanoConta(PlanoConta planoConta)
        {
            _model.ItemPlanoConta = _planoContaModelBuilder
                .Reset()
                .SetEntity(planoConta)
                .Build();
            return this;
        }

        public ITransacaoModelBuilder SetPlanoContas(List<PlanoConta> planoContas)
        {
            List<SelectListItem> itensPlanoConta = new();

            foreach (var item in planoContas)
            {
                itensPlanoConta.Add(new SelectListItem() { Text = item.Descricao, Value = item.Id.ToString() });
            }

            _model.PlanoContas = itensPlanoConta;
            return this;
        }
        
    }

}