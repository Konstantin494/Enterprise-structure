using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    /// <summary>
    /// Цеха и отделы
    /// </summary>
    public class Departament
    {
        private string name;
        private List<Sector> sectors;
        private List<Employee> employees;

        public string Name { get => name; set => name = value; }
        public List<Sector> Sectors { get => sectors; set => sectors = value; }
        public List<Employee> Employees { get => employees; set => employees = value; }

        public Departament(string name)
        {
            this.Name = name;
            this.Sectors = new List<Sector>();
            this.Employees = new List<Employee>();
        }
    }
}
