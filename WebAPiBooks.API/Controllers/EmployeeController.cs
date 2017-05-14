using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiBooks.BL.EmployeeBL;
using WebAPiBooks.API.Controllers;
using WebAPiBooks.Model;

namespace WebAPiBooks.API.Controllers
{
    public class EmployeeController : MasterController<EmployeeModel, EmployeeBl>
    {
        public override HttpResponseMessage Delete(int Id)
        {
            var result = _businesslogic.Delete(Id);
            if (result)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Item deleted successfully!");
            }
            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Item cannot be deleted!");
        }

        public override HttpResponseMessage Get()
        {
            throw new NotImplementedException();
        }

        public override HttpResponseMessage Get(int id)
        {
            throw new NotImplementedException();
        }

        public override HttpResponseMessage Post(EmployeeModel model)
        {
            throw new NotImplementedException();
        }

        public override HttpResponseMessage Put(EmployeeModel model)
        {
            throw new NotImplementedException();
        }
    }
}
