using System;
using CompIP.DAL.Entities;
using CompIP.DAL.Interfaces;
using CompIP.DAL.EFContext;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompIP.DAL.Repositories
{
    public class EntityUnitOfWork : IUnitOfWork
    {
        DepartmentContext context;

        OrganizationsRepository organizationRepository;
        EmployeesRepository employeesRepository;
        ComputersRepository computersRepository;

        public EntityUnitOfWork(string name)
        {
            context = new DepartmentContext(name);
        }

        public IRepository<Organization> Organizations
        {
            get
            {
                if (organizationRepository == null)
                    organizationRepository = new OrganizationsRepository(context);
                return organizationRepository;
            }
        }

        public IRepository<Employee> Employees
        {
            get
            {
                if (employeesRepository == null)
                    employeesRepository = new EmployeesRepository(context);
                return employeesRepository;
            }
        }

        public IRepository<Computer> Computers
        {
            get
            {
                if (computersRepository == null)
                    computersRepository = new ComputersRepository(context);
                return computersRepository;
            }
        }

        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }

                this.disposed = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
