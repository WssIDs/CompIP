using System;
using System.Collections.Generic;
using System.Data.Entity;
using CompIP.DAL.Entities;

namespace CompIP.DAL.EFContext
{
    class DepartmentInitializer : CreateDatabaseIfNotExists<DepartmentContext>
    {
        protected override void Seed(DepartmentContext context)
        {

            context.Organizations.AddRange(
                new Organization[]
                {
                    new Organization
                    {
                        Name = "Отдел идеологической работы, культуры и по делам молодежи Клецкого райисполкома",
                        Employees = new List<Employee>
                        {
                            new Employee
                            {
                                FullName = "Володько Виталий Иванович",
                                Room = 322,
                                Computers = new List<Computer>{ new Computer {Name = "MSI-LAPTOP", IP = "192.168.1.100" } } 
                            },
                            new Employee
                            {
                                FullName = "Салата Татьяна Ивановна",
                                Room = 322,
                                Computers = new List<Computer>{ new Computer {Name = "ECONOMIST", IP = "192.168.1.10" } }
                            }
                        }
                    }
                }

            );

            context.SaveChanges();

        }
    }
}
