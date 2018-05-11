using CompIP.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompIP.BusinessLayer.Models
{
    public class EmployeeViewModel
    {
        public int EmployeeId { get; set; }
        public string FullName { get; set; }
        public int Room { get; set; }

        public ObservableCollection<Computer> Computers { get; set; }
    }
}
