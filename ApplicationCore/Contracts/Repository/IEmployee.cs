using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Repository
{
    public interface IEmployee
    {
        int Insert(Employee e);
        int Delete(int id);
        int Update(Employee e);
        Employee GetById(int id);
        IEnumerable<Employee> GetAll();

    }
}
