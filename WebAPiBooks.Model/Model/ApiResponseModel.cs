using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPiBooks.Model.Enum;

namespace WebAPiBooks.Model.Model
{
    public class ApiResponseModel
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public MessageType MessageType {get;set;}
    }
}
