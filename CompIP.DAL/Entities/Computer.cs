using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompIP.DAL.Entities
{
    public class Computer
    {
        public int ComputerId { get; set; }
        public string Name { get; set; }
        public string IP { get; set; }

        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }
    }
}
