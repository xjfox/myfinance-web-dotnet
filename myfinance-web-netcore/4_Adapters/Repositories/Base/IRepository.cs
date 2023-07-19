namespace myfinance_web_netcore.Adapters.Repositories.Interfaces.Base
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Cadastrar(TEntity Entidade);

        void Excluir(int Id);

        List<TEntity> ListarRegistros();

        List<TEntity> ListarRegistros(params string[] navigationProperties);

        TEntity ObterRegistro(int Id);
    }
}