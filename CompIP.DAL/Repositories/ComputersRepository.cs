using CompIP.DAL.EFContext;
using CompIP.DAL.Entities;
using CompIP.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompIP.DAL.Repositories
{
    class ComputersRepository : IRepository<Computer>
    {
        DepartmentContext context;

        public ComputersRepository(DepartmentContext context)
        {
            this.context = context;
        }

        public void Create(Computer t)
        {
            context.Computers.Add(t);
        }

        public void Delete(int id)
        {
            var computer = context.Computers.Find(id);
            context.Computers.Remove(computer);
        }

        public IEnumerable<Computer> Find(Func<Computer, bool> predicate)
        {
            return context
                    .Computers
                    .Where(predicate)
                    .ToList();
        }

        public Computer Get(int id)
        {
            return context.Computers.Find(id);
        }

        public IEnumerable<Computer> GetAll()
        {
            return context.Computers;
        }

        public void Update(Computer t)
        {
            context.Entry<Computer>(t).State = EntityState.Modified;
        }
    }
}
