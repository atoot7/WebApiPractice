//using System.Collections.Generic;
//using System.Net;
//using System.Net.Http;
//using System.Net.Http.Formatting;
//using System.Threading;
//using System.Threading.Tasks;
//using System.Web.Http;
//using WebAPiBooks.Model.Model;

//namespace WebAPiBooks.API
//{
//    public class ApiResult<T> : IHttpActionResult where T : class
//    {
//        public HttpStatusCode StatusCode { get; set; }
//        private List<ApiResultHeaderMessagePair> HeadsToAdd { get; set; }
//        public ApiResultModel Content { get; set; }
//        private HttpRequestMessage Request { get; set; }

//        public ApiResult(HttpRequestMessage request, ApiResultModel data)
//        {
//            this.StatusCode = HttpStatusCode.OK;
//            this.HeadsToAdd = new List<ApiResultHeaderMessagePair>();
//            this.Request = request;
//            this.Content = data;
//        }
//        public void AddHeaders(string headerKey, string headerValue)
//        {
//            HeadsToAdd.Add(new ApiResultHeaderMessagePair(headerKey, headerValue));
//        }
//        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
//        {
//            var response = Request.CreateResponse();
//            foreach (var item in HeadsToAdd)
//            {
//                response.Headers.Add(item.Key, item.Value);
//            }
//            response.Content = Content.Data
//            return Task.FromResult(response);
//        }
//        private class ApiResultHeaderMessagePair
//        {
//            public ApiResultHeaderMessagePair(string key, string value)
//            {
//                this.Key = key;
//                this.Value = value;
//            }
//            public string Key;
//            public string Value;
//        }
//    }
//}