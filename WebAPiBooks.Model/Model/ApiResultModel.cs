using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPiBooks.Model.Model
{
   public class ApiResultModel
    {
        public object Data { get; set; }
        public bool ResultStatus { get; set; }
        public string MessageData { get; set; }
        public ApiResultModel(string message)
        {
            ResultStatus = false;
            MessageData = message;
        }
    }
}
