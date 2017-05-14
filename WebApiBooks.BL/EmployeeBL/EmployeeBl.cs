using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiBooks.Services.Employees;
using WebAPiBooks.Data;
using WebAPiBooks.Model;

namespace WebApiBooks.BL.EmployeeBL
{
    public class EmployeeBl : ICommonBl<EmployeeModel>
    {
        EmployeeRepository _repo = new EmployeeRepository();
        public bool Create(EmployeeModel model)
        {
            var entity = ModelToEntity(model);
            var result = _repo.Save(entity);
            return result;
        }


        public bool Delete(int Id)
        {
            var result = _repo.Delete(Id);
            return result;
        }

        public EmployeeModel Detail(int Id)
        {
            var result = _repo.Get(Id);
            EmployeeModel returnModel = EntityToModel(result);
            return returnModel;
        }

        public List<EmployeeModel> List()
        {
            var list = _repo.FindAll();
            var returnList = new List<EmployeeModel>();
            foreach (var employee in list)
            {
                returnList.Add(EntityToModel(employee));
            }
            return returnList;
        }

        public bool Update(EmployeeModel model)
        {
            var entity = ModelToEntity(model);
            var result = _repo.Update(entity);
            return result;
        }
        private static Employee ModelToEntity(EmployeeModel model)
        {
            var entity = new Employee()
            {
                AvailableLeave = model.AvailableLeave,
                CitizenshipNumber = model.CitizenshipNumber,
                CIT_Percentage = model.CIT_Percentage,
                CreditBalance = model.CreditBalance,
                EmployeeID = model.EmployeeID,
                Name = model.Name,
                NetSalary = model.NetSalary,
                PassportNumber = model.PassportNumber,
                PF_Percentage = model.PF_Percentage,
                Salary = model.Salary
            };
            return entity;
        }
        private static EmployeeModel EntityToModel(Employee result)
        {
            return new EmployeeModel()
            {
                AvailableLeave = result.AvailableLeave,
                CitizenshipNumber = result.CitizenshipNumber,
                CIT_Percentage = result.CIT_Percentage,
                CreditBalance = result.CreditBalance,
                EmployeeID = result.EmployeeID,
                Name = result.Name,
                NetSalary = result.NetSalary,
                PassportNumber = result.PassportNumber,
                PF_Percentage = result.PF_Percentage,
                Salary = result.Salary
            };
        }
    }
}
