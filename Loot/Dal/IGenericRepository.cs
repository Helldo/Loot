using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Loot.Dal
{
    public interface IGenericRepository<Tentity>
    {
        void Delete(object id);

        void Delete(Tentity entityToDelete);

        IEnumerable<Tentity> Get(Expression<Func<Tentity, bool>> filter = null,
            Func<IQueryable<Tentity>, IOrderedQueryable<Tentity>> orderBy = null,
            params Expression<Func<Tentity, object>>[] includeProperties);

        Tentity GetById(object id);

        void Insert(Tentity entity);

        void Update(Tentity entityToUpdate);
    }
}
