using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using CompIP.DAL.EFContext;
using CompIP.DAL.Entities;
using CompIP.DAL.Interfaces;

namespace CompIP.DAL.Repositories
{
    class OrganizationsRepository: IRepository<Organization>
    {
        DepartmentContext context;
        public OrganizationsRepository(DepartmentContext context)
        {
            this.context = context;
        }

        public void Create(Organization t)
        {
            context.Organizations.Add(t);
        }

        public void Delete(int id)
        {
            var organization = context.Organizations.Find(id);
            context.Organizations.Remove(organization);
        }

        public IEnumerable<Organization> Find(Func<Organization, bool> predicate)
        {
            return context
                    .Organizations
                    .Include(em => em.Employees)
                    .Where(predicate)
                    .ToList();
        }

        public Organization Get(int id)
        {
            return context.Organizations.Find(id);
        }

        public IEnumerable<Organization> GetAll()
        {
            return context.Organizations.Include(em => em.Employees);
        }

        public void Update(Organization t)
        {
            context.Entry<Organization>(t).State = EntityState.Modified;
        }
    }
}
