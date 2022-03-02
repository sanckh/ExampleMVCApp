using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Contracts.Repository;
using ApplicationCore.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repository
{
    public class EmployeeRepository : IEmployee
    {
        protected readonly EmployeeContextDB db;
        public EmployeeRepository(EmployeeContextDB _db)
        {
            db = _db;
        }
        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public Employee GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Employee e)
        {
            throw new NotImplementedException();
        }

        public int Update(Employee e)
        {
            throw new NotImplementedException();
        }
    }
}
