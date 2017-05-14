using System.Net.Http;
using System.Web.Http;

namespace WebAPiBooks.API.Controllers
{
    public abstract class MasterController<TModel, TBusinessLogic> : ApiController where TModel : class where TBusinessLogic : class, new()
    {
        public TBusinessLogic _businesslogic = new TBusinessLogic();
        public abstract HttpResponseMessage Get();
        public abstract HttpResponseMessage Get(int id);
        public abstract HttpResponseMessage Post(TModel model);
        public abstract HttpResponseMessage Put(TModel model);
        public abstract HttpResponseMessage Delete(int Id);
    }
}
