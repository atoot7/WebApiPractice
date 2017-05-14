using WebAPiBooks.Data;

namespace WebApiBooks.Services
{
    public abstract class BaseService<TRepo, TEntity,TdBContext> where TRepo : class where TEntity : class where TdBContext: WebApiEntities
    {
        public void Save(TEntity entity)
        {

        }
    }
}
