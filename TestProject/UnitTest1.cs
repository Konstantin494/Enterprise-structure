using System;
using NUnit.Framework;
using BLL;

namespace TestProject
{
    public class UnitTest1
    {
        [Test]
        public void TestGetInitialsEmployee()
        {
            Employee employee = new Employee("Сидоров", "Андрей", "Иванович", new DateTime(1996, 12, 1), new DateTime(2018, 5, 30), Roles.cat_2, 0);
            Assert.AreEqual("Сидоров А.И.", employee.GetSurnameAndFirstLettersOfNameAndPatronymic());
        }

        [Test]
        public void TestPrintStructure() // проверям вывод структуры
        {
            Enterprise enterprise = new Enterprise("ОАО Завод");
            Departament departament1 = new Departament("Отдел главного конструктора");
            Departament departament2 = new Departament("Сборочный цех");
            Sector sector1 = new Sector("Конструкторское бюро 1");
            Sector sector2 = new Sector("Конструкторское бюро 2");
            Sector sector3 = new Sector("Участок 1");
            Sector sector4 = new Sector("Участок 2");
            Employee employee1 = new Employee("Иванов", "Иван", "Иванович", new DateTime(1996, 12, 1), new DateTime(2018, 5, 30), Roles.cat_2, 0);
            Employee employee2 = new Employee("Сергеев", "Сергей", "Сергеевич", new DateTime(1986, 11, 16), new DateTime(2012, 3, 20), Roles.head, 1);
            enterprise.Departaments.Add(departament1);
            enterprise.Departaments.Add(departament2);
            departament1.Sectors.Add(sector1);
            departament1.Sectors.Add(sector2);
            departament2.Sectors.Add(sector3);
            departament2.Sectors.Add(sector4);
            sector1.Employees.Add(employee1);
            sector4.Employees.Add(employee2);
            Assert.AreEqual(
                "ОАО Завод" +
                "\n   Отдел главного конструктора" +
                "\n      Конструкторское бюро 1" +
                "\n         Иванов И.И." +
                "\n      Конструкторское бюро 2" +
                "\n   Сборочный цех" +
                "\n      Участок 1" +
                "\n      Участок 2" +
                "\n         Сергеев С.С.",
                enterprise.GetStructure());
        }
        [Test]
        public void TestCalculationSalary()
        {
            Employee employee = new Employee("Сидоров", "Андрей", "Иванович", new DateTime(1996, 12, 1), new DateTime(2018, 5, 30), Roles.cat_2, 0);
            Assert.AreEqual(49920, employee.CalculateSalary(156, 200));
        }

        [TestCase(0, 5, ExpectedResult = 0)]
        [TestCase(196, 100, ExpectedResult = 41160)]
        public double TestCalculationSalary(int hours, double amount)
        {
            Employee employee = new Employee("Сергеев", "Сергей", "Сергеевич", new DateTime(1986, 11, 16), new DateTime(2012, 3, 20), Roles.head, 1);
            return employee.CalculateSalary(hours, amount);
        }

        [TestCase(-5, 360)]
        public void TestExceptionOfCalculationSalary(int hours, double amount)
        {
            Employee employee = new Employee("Сергеев", "Сергей", "Сергеевич", new DateTime(1986, 11, 16), new DateTime(2012, 3, 20), Roles.head, 1);
            Assert.Throws<Exception>(() => employee.CalculateSalary(hours, amount));
        }
    }
}
