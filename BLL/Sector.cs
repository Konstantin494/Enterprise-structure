using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    /// <summary>
    /// Участки и бюро
    /// </summary>
    public class Sector
    {
        private string name;
        private List<Employee> employees;

        public string Name { get => name; set => name = value; }
        public List<Employee> Employees { get => employees; set => employees = value; }
        public Sector(string name)
        {
            this.Name = name;
            this.Employees = new List<Employee>();
        }
    }
}
