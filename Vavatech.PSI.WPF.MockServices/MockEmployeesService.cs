using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vavatech.PSI.WPF.IServices;
using Vavatech.PSI.WPF.Models;

namespace Vavatech.PSI.WPF.MockServices
{
    public class MockEmployeesService : IEmployeesService
    {
        private IList<Employee> employees = new List<Employee>();

        public MockEmployeesService()
        {

            employees = Enumerable.Range(1, 1000)
                .Select(i => new Employee(i, "John", "Smith"))
                .ToList();

            //for (int i = 0; i < 1000; i++)
            //{
            //    var employee = new Employee(i, "John", "Smith");
            //    employees.Add(employee);
            //}
        }

        public void Add(Employee entity) => employees.Add(entity);

        public IList<Employee> Get() => employees;

        public Employee Get(int id) => employees.SingleOrDefault(e => e.Id == id);

        public Task<IList<Employee>> GetAsync() => Task.Run(() => Get());

        public void Remove(Employee entity) => employees.Remove(entity);

        public void Update(Employee entity)
        {
            throw new NotImplementedException();
        }
    }
}
