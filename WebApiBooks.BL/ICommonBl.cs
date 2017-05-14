using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiBooks.BL
{
    public interface ICommonBl<TModel> where TModel : class
    {
        List<TModel> List();
        bool Create(TModel model);
        bool Update(TModel model);
        bool Delete(int Id);
        TModel Detail(int Id);
    }
}
