using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Contracts.Repository;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using Infrastructure.Data;

namespace Infrastructure.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployee _employeeRepository;
        public EmployeeService(IEmployee _es)
        {
            _employeeRepository = _es;
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
