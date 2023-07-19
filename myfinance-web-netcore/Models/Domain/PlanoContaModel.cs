using myfinance_web_netcore.Entities;
using myfinance_web_netcore.Models.Domain.Base;

namespace myfinance_web_netcore.Models.Domain
{
    public class PlanoContaModel : Model
    {
        public string Descricao {  get; set; }
        public string Tipo { get; set; }

        public static PlanoContaModel Build(PlanoConta? planoConta)
        {
            PlanoContaModelBuilder planoContaModelBuilder = new();
            return planoContaModelBuilder.Reset()
                .SetEntity(planoConta)
                .Build();
        }

        public static List<PlanoContaModel> Build(List<PlanoConta> planoContas)
        {
            List<PlanoContaModel> planoContaModels = new();

            foreach (PlanoConta planoConta in planoContas)
            {
                planoContaModels.Add(Build(planoConta));
            }
            
            return planoContaModels;
        }

        protected override string RemoveConfirmMessage()
        {
            return "Você tem certeza que deseja excluir o plano de conta " + this.Descricao + "?";
        }

        protected override string BaseController()
        {
            return "PlanoConta";
        }

        public override PlanoConta ToDomain()
        {
            return new PlanoConta(){
                Id = Id,
                Descricao = Descricao,
                Tipo = Tipo
            };
        }

    }
}