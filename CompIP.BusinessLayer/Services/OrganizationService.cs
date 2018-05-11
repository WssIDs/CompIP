using System;
using System.Collections.ObjectModel;
using CompIP.BusinessLayer.Interfaces;
using CompIP.DAL.Entities;
using CompIP.BusinessLayer.Models;
using CompIP.DAL.Interfaces;
using CompIP.DAL.Repositories;
using AutoMapper;

namespace CompIP.BusinessLayer.Services
{
    public class OrganizationService : IOrganizationService
    {
        IUnitOfWork dataBase;
        public OrganizationService(string name)
        {
            dataBase = new EntityUnitOfWork(name);
        }

        public void AddEmployeeToOrganization(int organizationId, EmployeeViewModel employee)
        {
            var organization = dataBase.Organizations.Get(organizationId);

            // Конфигурировани AutoMapper
            Mapper.Initialize(cfg => cfg.CreateMap<EmployeeViewModel, Employee>());
            // Отображение объекта EmployeeViewModel на объект Employee
            var empl = Mapper.Map<Employee>(employee);
            // Добавить сотрудника    
            organization.Employees.Add(empl);

            // Сохранить изменения
            dataBase.Save(); 
        }

        public void CreateOrganization(OrganizationViewModel organization)
        {
            throw new NotImplementedException();
        }

        public void DeleteOrganization(int organizationId)
        {
            throw new NotImplementedException();
        }

        public OrganizationViewModel Get(int id)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<OrganizationViewModel> GetAll()
        {
            Mapper.Reset();
            // Конфигурировани AutoMapper
            Mapper.Initialize(cfg => {
                cfg.CreateMap<Organization, OrganizationViewModel>();
                cfg.CreateMap<Employee, EmployeeViewModel>();
            });

            // Отображение List<Group> на ObservableCollection<GroupViewModel>
            var organizations = Mapper.Map<ObservableCollection<OrganizationViewModel>>(dataBase.Organizations.GetAll());
            return organizations; 
        }

        public void RemoveEmployeeFromOrganization(int organizationId, int employeeId)
        {
            throw new NotImplementedException();
        }

        public void UpdateOrganization(OrganizationViewModel organization)
        {
            throw new NotImplementedException();
        }
    }
}
