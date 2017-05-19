using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiBooks.BL.EmployeeBL;
using WebAPiBooks.API.Controllers;
using WebAPiBooks.Model.Model;

namespace WebAPiBooks.API.Controllers
{
    public class EmployeeController : MasterController<EmployeeModel, EmployeeBl>
    {
        public override HttpResponseMessage Delete(int Id)
        {
            var result = _businesslogic.Delete(Id);
            if (result)
            {
                var model = new ApiResultModel("Employee successfully deleted!")
                {
                    ResultStatus = true
                };
                return Request.CreateResponse(HttpStatusCode.OK, model);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, new ApiResultModel("Item cannot be deleted!"));
            }
        }

        public override HttpResponseMessage Get()
        {
            try
            {
                var result = _businesslogic.List();
                var model = new ApiResultModel("Item retrieved!")
                {
                    ResultStatus = true,
                    Data = result
                };
                return Request.CreateResponse(HttpStatusCode.OK, model);
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.OK, new ApiResultModel("Item cannot be deleted!"));

            }
        }

        public override HttpResponseMessage Get(int id)
        {
            try
            {
                var result = _businesslogic.Detail(id);
                var model = new ApiResultModel("Details retrieved")
                {
                    Data = result,
                    ResultStatus = true
                };
                return Request.CreateResponse(HttpStatusCode.OK, model);

            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.OK, new ApiResultModel("Item cannot be deleted!"));

            }
        }

        public override HttpResponseMessage Post(EmployeeModel model)
        {
            try
            {
                var result = _businesslogic.Create(model);
                var resultModel = new ApiResultModel("Employee created successfully!")
                {
                    ResultStatus = true
                };
                return Request.CreateResponse(HttpStatusCode.OK, resultModel);

            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.OK, new ApiResultModel("Item cannot be deleted!"));

            }
        }

        public override HttpResponseMessage Put(EmployeeModel model)
        {
            try
            {
                var result = _businesslogic.Update(model);
                var resultModel = new ApiResultModel("Employee created successfully!")
                {
                    ResultStatus = true
                };
                return Request.CreateResponse(HttpStatusCode.OK, resultModel);

            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.OK, new ApiResultModel("Item cannot be deleted!"));
            }
        }
    }
}
