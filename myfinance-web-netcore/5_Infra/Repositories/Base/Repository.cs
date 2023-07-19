using Microsoft.EntityFrameworkCore;
using myfinance_web_netcore.Entities.Base;
using myfinance_web_netcore.Adapters.Repositories.Interfaces.Base;

namespace myfinance_web_netcore.Infra.Repositories.Base
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : EntityBase, new()
    {
        protected DbContext Db;
        protected DbSet<TEntity> DbSetContext; 

        public Repository(DbContext dbContext)
        {
            Db = dbContext;
            DbSetContext = Db.Set<TEntity>();
        }

        public void Cadastrar(TEntity Entidade)
        {
            if (Entidade.Id == null) {
                DbSetContext.Add(Entidade);
            } else {
                DbSetContext.Attach(Entidade);
                Db.Entry(Entidade).State = EntityState.Modified;
            }

            Db.SaveChanges();
        }

        public void Excluir(int Id)
        {
            var entidade = new TEntity(){ Id = Id };
            Db.Attach(entidade);
            Db.Remove(entidade);
            Db.SaveChanges();
        }

        public List<TEntity> ListarRegistros()
        {
            return DbSetContext.ToList();
        }

        public List<TEntity> ListarRegistros(params string[] navigationProperties)
        {
            var query = DbSetContext.AsQueryable();

            foreach (var navigationProperty in navigationProperties)
            {
                query = query.Include(navigationProperty);
            }

            return query.ToList();
        }

        public TEntity ObterRegistro(int Id)
        {
            return DbSetContext.Where(x => x.Id == Id).First();
        }

    }
}