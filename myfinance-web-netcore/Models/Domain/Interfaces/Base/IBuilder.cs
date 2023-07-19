namespace myfinance_web_netcore.Models.Domain.Interfaces.Base
{
    public interface IBuilder<TModel, TEntity, TBuilder>
        where TModel : class
        where TEntity : class
    {
        public TBuilder Reset();
        public TModel Build();
        public abstract TBuilder SetEntity(TEntity? entity);

    }
}