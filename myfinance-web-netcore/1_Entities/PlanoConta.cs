using myfinance_web_netcore.Entities.Base;

namespace myfinance_web_netcore.Entities
{
    public class PlanoConta : EntityBase
    {   
        public string Descricao {  get; set; }
        public string Tipo { get; set; }
    }
}