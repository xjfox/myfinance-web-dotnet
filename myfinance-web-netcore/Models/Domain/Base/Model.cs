using myfinance_web_netcore.Entities.Base;
using myfinance_web_netcore.Models.Domain.Interfaces.Base;


namespace myfinance_web_netcore.Models.Domain.Base
{
    public abstract class Model : IModel
    {
        public int? Id { get; set; }

        public abstract EntityBase ToDomain();

        protected abstract string BaseController();

        protected abstract string RemoveConfirmMessage();

        protected string RemoveAction()
        {
            return "Excluir";
        }

        public ConfirmRemoveButtonParamsModel ConfirmRemoveButtonParams() {
            return new ConfirmRemoveButtonParamsModel(){
                Id = Id ?? 0,
                Controller = BaseController(),
                Action = RemoveAction(),
                ConfirmMessage = RemoveConfirmMessage()
            };
        }
    }
}