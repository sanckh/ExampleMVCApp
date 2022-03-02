using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Entities;

namespace ApplicationCore.Contracts.Services
{
    public interface IEmployeeService
    {
        int Insert(Employee e);
        int Delete(int id);
        int Update(Employee e);
        Employee GetById(int id);
        IEnumerable<Employee> GetAll();
    }
}
