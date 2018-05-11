using System.Collections.ObjectModel;
using CompIP.BusinessLayer.Models;

namespace CompIP.BusinessLayer.Interfaces
{
    public interface IEmployeeService
    {
        ObservableCollection<EmployeeViewModel> GetAll();
        EmployeeViewModel Get(int id);
        void RemoveComputerFromEmployee(int employeeId, int computerId);
        void CreateEmployee(EmployeeViewModel employee);
        void DeleteEmployeen(int employeeId);
        void UpdateEmployee(EmployeeViewModel employee);
    }
}
