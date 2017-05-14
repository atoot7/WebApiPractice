using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPiBooks.IRepository
{
    public interface IRepository<TEntity, in TKey> where TEntity : class
    {
        TEntity Get(TKey id);
        bool Save(TEntity entity);
        bool Delete(int id);
        bool Update(TEntity entity);
    }
}