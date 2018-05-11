using CompIP.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompIP.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Organization> Organizations { get; }
        IRepository<Employee> Employees { get; }
        IRepository<Computer> Computers { get; }
        void Save();
    }
}
