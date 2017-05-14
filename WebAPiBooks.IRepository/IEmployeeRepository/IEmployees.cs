using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPiBooks.Data;
using WebAPiBooks.IRepository;

namespace WebAPiBooks.IRepository.IEmployeeRepository
{
    public interface IEmployeeRepository : IRepository<Employee, int>
    {
        IEnumerable<Employee> FindAll();
        IEnumerable<Employee> Find(int id);
    }
}
