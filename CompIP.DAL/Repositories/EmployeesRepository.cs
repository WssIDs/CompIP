using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using CompIP.DAL.EFContext;
using CompIP.DAL.Entities;
using CompIP.DAL.Interfaces;

namespace CompIP.DAL.Repositories
{
    public class EmployeesRepository : IRepository<Employee>
    {
        DepartmentContext context;
        public EmployeesRepository(DepartmentContext context)
        {
            this.context = context;
        }

        public void Create(Employee t)
        {
            context.Employees.Add(t);
        }

        public void Delete(int id)
        {
            var employee = context.Employees.Find(id);
            context.Employees.Remove(employee);
        }

        public IEnumerable<Employee> Find(Func<Employee, bool> predicate)
        {
            return context
                    .Employees
                    .Include(c => c.Computers)
                    .Where(predicate)
                    .ToList();
        }

        public Employee Get(int id)
        {
            return context.Employees.Find(id);
        }

        public IEnumerable<Employee> GetAll()
        {
            return context.Employees.Include(c => c.Computers);
        }

        public void Update(Employee t)
        {
            context.Entry<Employee>(t).State = EntityState.Modified;
        }
    }
}
