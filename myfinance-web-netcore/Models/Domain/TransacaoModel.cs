using Microsoft.AspNetCore.Mvc.Rendering;
using myfinance_web_netcore.Entities;
using myfinance_web_netcore.Models.Domain.Base;

namespace myfinance_web_netcore.Models.Domain
{
    public class TransacaoModel : Model
    {
        public DateTime Data {  get; set; }
        public decimal Valor { get; set; }
        public string Historico { get; set; }
        public int PlanoContaId { get; set; }
        public PlanoContaModel ItemPlanoConta { get; set; }
        public IEnumerable<SelectListItem>? PlanoContas { get; set; }

        public static TransacaoModel Build(Transacao? transacao)
        {
            return Build(transacao, null);
        }

        public static List<TransacaoModel> Build(List<Transacao> transacoes)
        {
            return Build(transacoes, null);
        }

        public static TransacaoModel Build(Transacao? transacao, List<PlanoConta>? planoContas)
        {
            TransacaoModelBuilder transacaoModelBuilder = new(new PlanoContaModelBuilder());
            transacaoModelBuilder = (TransacaoModelBuilder)transacaoModelBuilder.Reset()
                .SetEntity(transacao);

            if (planoContas != null)
            {
                transacaoModelBuilder.SetPlanoContas(planoContas);
            }
            
            return transacaoModelBuilder.Build();
        }

        public static List<TransacaoModel> Build(List<Transacao> transacoes, List<PlanoConta>? planoContas)
        {
            List<TransacaoModel> transacaoModels = new();

            foreach (Transacao transacao in transacoes)
            {
                transacaoModels.Add(Build(transacao, planoContas));
            }
            
            return transacaoModels;
        }

        protected override string RemoveConfirmMessage()
        {
            return "Você tem certeza que deseja excluir a transasção nº " + this.Id + "?";
        }

        protected override string BaseController()
        {
            return "Transacao";
        }

        public override Transacao ToDomain()
        {
            return new Transacao(){
                Id = Id,
                Data = Data,
                Historico = Historico,
                Valor = Valor,
                PlanoContaId = PlanoContaId
            };
        }

    }
}