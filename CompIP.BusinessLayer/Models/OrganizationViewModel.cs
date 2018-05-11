using CompIP.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompIP.BusinessLayer.Models
{
    public class OrganizationViewModel
    {
        public int OrganizationId { get; set; }
        public string Name { get; set; }

        public ObservableCollection<Employee> Employees { get; set; }
    }
}
