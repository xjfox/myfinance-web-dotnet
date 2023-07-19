using myfinance_web_netcore.Entities.Base;
using myfinance_web_netcore.Models.Domain.Interfaces.Base;

namespace myfinance_web_netcore.Models.Domain.Base
{
    public abstract class Builder<TModel, TEntity, TBuilder> : IBuilder<TModel, TEntity, TBuilder>
        where TModel : Model, new()
        where TEntity : EntityBase, new()
    {
        protected TModel _model;

        public abstract TBuilder SetEntity(TEntity? entity);

        public Builder()
        {
            _model = new TModel();
        }

        public TBuilder Reset()
        {
            _model = new TModel();
            return (TBuilder)(object)this;
        }

        public TModel Build()
        {
            var model = _model;
            Reset();
            return model;
        }

    }
}