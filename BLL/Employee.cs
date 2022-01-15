using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    /// <summary>
    /// Сотрудник
    /// </summary>
    public class Employee
    {
        private int id;
        private string name;
        private string surname;
        private string patronymic;
        private DateTime dateOfBirth;
        private Roles role;
        private string dateOfEmployment;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Patronymic { get => patronymic; set => patronymic = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public Roles Role { get => role; set => role = value; }
        public string DateOfEmployment { get => dateOfEmployment; set => dateOfEmployment = value; }

        public Employee()
        {

        }

        public Employee(string surname, string name, string patronymic, DateTime dateOfBirth, DateTime dateOfEmployment, string role, int id)
        {
            this.Name = name;
            this.Patronymic = patronymic;
            this.Surname = surname;
            this.DateOfBirth = dateOfBirth;
            this.DateOfEmployment = DateOfEmployment;
            if (role == "Начальник")
                this.role = Roles.head;
            if (role == "Инженер 1 кат.")
                this.role = Roles.cat_1;
            if (role == "Инженер 2 кат.")
                this.role = Roles.cat_2;
            if (role == "Инженер 3 кат.")
                this.role = Roles.cat_3;
            this.Id = id;
        }

        public Employee(string surname, string name, string patronymic, DateTime dateOfBirth, DateTime dateOfEmployment, Roles role, int id)
        {
            this.Name = name;
            this.Patronymic = patronymic;
            this.Surname = surname;
            this.DateOfBirth = dateOfBirth;
            this.DateOfEmployment = DateOfEmployment;
            this.role = role;
            this.Id = id;
        }

        /// <summary>
        /// Возвращает инициалы
        /// </summary>
        public string GetSurnameAndFirstLettersOfNameAndPatronymic()
        {
            return this.Surname + " " + this.Name.Substring(0, 1) + "." + this.Patronymic.Substring(0, 1) + ".";
        }

        /// <summary>
        /// Возвращает зарпллату на основе должности, отработанных часов и оклада в час.
        /// </summary>
        public double CalculateSalary(int hours, double amount)
        {
            if (hours < 0)
                throw new Exception("Количество часов не может быть отрицательным числом");
            if (amount < 0)
                throw new Exception("Оплата в час не может быть отрицательным числом");
            double kof = 1;
            if (this.Role == Roles.head)
                kof = 2.1;
            if (this.Role == Roles.cat_1)
                kof = 1.3;
            if (this.Role == Roles.cat_2)
                kof = 1.6;
            if (this.Role == Roles.cat_3)
                kof = 1.9;

            return hours * amount * kof;   
        }
    }
}
