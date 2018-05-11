using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompIP.DAL.Entities
{
    public class Employee
    {
        public Employee()
        {
            Computers = new List<Computer>();
        }

        public int EmployeeId { get; set; }
        public string FullName { get; set; }
        public int Room { get; set; }

        public List<Computer> Computers { get; set; }

        public int OrganizationId { get; set; }
        public Organization Organization { get; set; }

    }
}
