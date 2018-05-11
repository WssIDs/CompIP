using AutoMapper;
using CompIP.BusinessLayer.Interfaces;
using CompIP.BusinessLayer.Models;
using CompIP.DAL.Entities;
using CompIP.DAL.Interfaces;
using CompIP.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompIP.BusinessLayer.Services
{
    public class EmployeeService : IEmployeeService
    {
        IUnitOfWork dataBase;
        public EmployeeService(string name)
        {
            dataBase = new EntityUnitOfWork(name);
        }

        public void CreateEmployee(EmployeeViewModel employee)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployeen(int employeeId)
        {
            throw new NotImplementedException();
        }

        public EmployeeViewModel Get(int id)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<EmployeeViewModel> GetAll()
        {
            Mapper.Reset();
            // Конфигурировани AutoMapper
            Mapper.Initialize(cfg => {
                cfg.CreateMap<Employee, EmployeeViewModel>();
            });

            // Отображение List<Employee> на ObservableCollection<EmployeeViewModel>
            var employees = Mapper.Map<ObservableCollection<EmployeeViewModel>>(dataBase.Employees.GetAll());
            return employees;
        }

        public void RemoveComputerFromEmployee(int employeeId, int computerId)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployee(EmployeeViewModel employee)
        {
            throw new NotImplementedException();
        }
    }
}
