using System.Collections.ObjectModel;
using CompIP.BusinessLayer.Models;

namespace CompIP.BusinessLayer.Interfaces
{
    public interface IOrganizationService
    {
        ObservableCollection<OrganizationViewModel> GetAll();
        OrganizationViewModel Get(int id);
        void AddEmployeeToOrganization(int organizationId, EmployeeViewModel employee);
        void RemoveEmployeeFromOrganization(int organizationId, int employeeId);
        void CreateOrganization(OrganizationViewModel organization);
        void DeleteOrganization(int organizationId);
        void UpdateOrganization(OrganizationViewModel organization);
    }
}
