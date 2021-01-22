using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Wlays.EntityFramework.Repositories
{
    public abstract class WlaysRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<WlaysDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected WlaysRepositoryBase(IDbContextProvider<WlaysDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class WlaysRepositoryBase<TEntity> : WlaysRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected WlaysRepositoryBase(IDbContextProvider<WlaysDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
