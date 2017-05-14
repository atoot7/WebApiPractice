using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPiBooks.Data;

namespace WebApiBooks.Services.Employees
{
    public class EmployeeRepository : WebAPiBooks.IRepository.IEmployeeRepository.IEmployeeRepository
    {
        public bool Delete(int id)
        {
            try
            {
                using (var ent = new WebApiEntities())
                {
                    var employee = ent.Employee.FirstOrDefault(x => x.EmployeeID == id);
                    if (employee != null)
                    {
                        ent.Employee.Remove(employee);
                        ent.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<Employee> Find(int id)
        {
            using (var ent = new WebApiEntities())
            {
                var iEnumerable = ent.Employee.Where(x => x.EmployeeID == id).AsEnumerable();
                return iEnumerable;
            }
        }

        public IEnumerable<Employee> FindAll()
        {
            using (var ent = new WebApiEntities())
            {
                var iEnumerable = ent.Employee.AsEnumerable();
                return iEnumerable;
            }
        }

        public Employee Get(int id)
        {
            using (var ent = new WebApiEntities())
            {
                var employee = ent.Employee.FirstOrDefault(x => x.EmployeeID == id);
                return employee;
            }
        }

        public bool Save(Employee entity)
        {
            try
            {
                using (var ent = new WebApiEntities())
                {
                    ent.Employee.Add(entity);
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(Employee entity)
        {
            try
            {
                using (var ent = new WebApiEntities())
                {
                    var employee = ent.Employee.FirstOrDefault(x => x.EmployeeID == entity.EmployeeID);
                    if (employee != null)
                    {
                        employee.Name = entity.Name;
                        employee.NetSalary = entity.NetSalary;
                        employee.PassportNumber = entity.PassportNumber;
                        employee.PF_Percentage = entity.PF_Percentage;
                        employee.Salary = entity.Salary;
                        employee.CIT_Percentage = entity.CIT_Percentage;
                        employee.CitizenshipNumber = employee.CitizenshipNumber;
                        employee.AvailableLeave = employee.AvailableLeave;
                        employee.CreditBalance = employee.CreditBalance;
                        ent.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
