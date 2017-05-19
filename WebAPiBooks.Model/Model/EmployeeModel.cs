using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPiBooks.Model.Model
{
    public class EmployeeModel
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public decimal CIT_Percentage { get; set; }
        public decimal PF_Percentage { get; set; }
        public decimal? NetSalary { get; set; }
        public string CitizenshipNumber { get; set; }
        public string PassportNumber { get; set; }
        public decimal? CreditBalance { get; set; }
        public int? AvailableLeave { get; set; }
    }
}
