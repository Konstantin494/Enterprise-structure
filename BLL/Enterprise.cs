using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    /// <summary>
    /// Предприятие
    /// </summary>
    public class Enterprise
    {
        private string name;
        private List<Departament> departaments;
        private List<Employee> employees;

        public string Name { get => name; set => name = value; }
        public List<Departament> Departaments { get => departaments; set => departaments = value; }
        public List<Employee> Employees { get => employees; set => employees = value; }
        public Enterprise(string name)
        {
            this.Name = name;
            this.Departaments = new List<Departament>();
            this.Employees = new List<Employee>();
        }

        public string GetStructure()
        {
            string spaces = "   ";
            string result = this.name;
            foreach (Departament d in this.Departaments)
            {
                result += "\n" + spaces + d.Name;
                foreach (Sector s in d.Sectors)
                {
                    result += "\n" + spaces + spaces + s.Name;
                    foreach (Employee e in s.Employees)
                    {
                        result += "\n" + spaces + spaces + spaces + e.GetSurnameAndFirstLettersOfNameAndPatronymic();
                    }
                }
                foreach (Employee e in d.Employees)
                {
                    result += "\n" + spaces + spaces + e.GetSurnameAndFirstLettersOfNameAndPatronymic();
                }
            }
            foreach (Employee e in this.Employees)
            {
                result += "\n" + spaces + e.GetSurnameAndFirstLettersOfNameAndPatronymic();
            }
            return result;
        }

        public void SaveStructure()
        {

        }
    }
}
