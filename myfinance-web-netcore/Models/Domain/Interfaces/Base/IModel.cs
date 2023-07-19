using myfinance_web_netcore.Entities.Base;

namespace myfinance_web_netcore.Models.Domain.Interfaces.Base
{
    public interface IModel
    {
        abstract EntityBase ToDomain();
        ConfirmRemoveButtonParamsModel ConfirmRemoveButtonParams();
    }
}