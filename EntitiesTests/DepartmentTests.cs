using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entities;

namespace EntitiesTests
{
    /// <summary>
    /// Summary description for DepartmentTests
    /// </summary>
    [TestClass]
    public class DepartmentTests
    {
        #region Employees

        [TestMethod]
        public void EmployeesInDepartment()
        {
            //  Arrange
            List<Employee> employees = new List<Employee>();
            
            decimal christmasBonus = 1m;
            string firstname = "Karl";
            string lastnames = "Karlsen";
            decimal monthlyBaseSalary = 100m;
            decimal monthlyBonusSalary = 10m;
            string ssn = "2009931234";
            Employee emp = new Employee(firstname, lastnames, ssn, monthlyBaseSalary, monthlyBonusSalary, christmasBonus);
            
            List<Employee> temployees = new List<Employee>();
            decimal tchristmasBonus = 500m;
            string tfirstname = "Ib";
            string tlastnames = "Ibsen";
            decimal tmonthlyBaseSalary = 5000m;
            decimal tmonthlyBonusSalary = 10m;
            string tssn = "2009931234";
            Employee temp = new Employee(tfirstname, tlastnames, tssn, tmonthlyBaseSalary, tmonthlyBonusSalary, tchristmasBonus);
            
            employees.Add(emp);
            employees.Add(temp);

            decimal yearlyBudget = 5601m;

            //  Act
            Department department = new Department(employees, yearlyBudget);

            //  Assert
            Assert.AreEqual(employees.Count, department.Employees.Count);

        }

        #endregion

        #region MonthlyPayout

        [TestMethod]
        public void MonthlyPayoutInDepartment()
        {
            //  Arrange
            List<Employee> employees = new List<Employee>();

            decimal christmasBonus = 1m;
            string firstname = "Karl";
            string lastnames = "Karlsen";
            decimal monthlyBaseSalary = 100m;
            decimal monthlyBonusSalary = 10m;
            string ssn = "2009931234";
            Employee emp = new Employee(firstname, lastnames, ssn, monthlyBaseSalary, monthlyBonusSalary, christmasBonus);
            
            decimal tchristmasBonus = 500m;
            string tfirstname = "Ib";
            string tlastnames = "Ibsen";
            decimal tmonthlyBaseSalary = 5000m;
            decimal tmonthlyBonusSalary = 10m;
            string tssn = "2009931234";
            Employee temp = new Employee(tfirstname, tlastnames, tssn, tmonthlyBaseSalary, tmonthlyBonusSalary, tchristmasBonus);

            employees.Add(emp);
            employees.Add(temp);

            decimal yearlyBudget = 10000m;
            decimal expectedPayout = 3328m;

            //  Act
            Department department = new Department(employees, yearlyBudget);
           
            //  Assert
            Assert.AreEqual(expectedPayout, department.MonthlyPayout);

        }

        #endregion

        #region YearlyPayout

        [TestMethod]
        public void YearlyPayoutInDepartment()
        {
            //  Arrange
            List<Employee> employees = new List<Employee>();

            decimal christmasBonus = 1m;
            string firstname = "Karl";
            string lastnames = "Karlsen";
            decimal monthlyBaseSalary = 100m;
            decimal monthlyBonusSalary = 10m;
            string ssn = "2009931234";
            Employee emp = new Employee(firstname, lastnames, ssn, monthlyBaseSalary, monthlyBonusSalary, christmasBonus);

            List<Employee> temployees = new List<Employee>();
            decimal tchristmasBonus = 500m;
            string tfirstname = "Ib";
            string tlastnames = "Ibsen";
            decimal tmonthlyBaseSalary = 5000m;
            decimal tmonthlyBonusSalary = 10m;
            string tssn = "2009931234";
            Employee temp = new Employee(tfirstname, tlastnames, tssn, tmonthlyBaseSalary, tmonthlyBonusSalary, tchristmasBonus);

            employees.Add(emp);
            employees.Add(temp);

            decimal yearlyBudget = 10000m;
            decimal expectedPayout = 40261.65m;

            //  Act
            Department department = new Department(employees, yearlyBudget);

            //  Assert
            Assert.AreEqual(expectedPayout, department.YearlyPayout);

        }

        #endregion

        #region YearlyBudget

        [TestMethod]
        public void YearlyBudgetInDepartment()
        {
            //  Arrange
            List<Employee> employees = new List<Employee>();
            
            Employee emp = new Employee(/*firstname = */"Karl", /* lastnames = */ "Karlsen", /* ssn =*/ "2009931234",
                /* monthlyBaseSalary = */ 100m, /* monthlyBonusSalary = */ 10m, /* christmasBonus = */ 1m);
            Employee temp = new Employee("Ib", "Ibsen", "2009931234", 5000m, 10m, 500m);

            employees.Add(emp);
            employees.Add(temp);

            decimal yearlyBudget = 10000m;
            //decimal expectedPayout = 40261.65m;

            //  Act
            Department department = new Department(employees, yearlyBudget);
            
            //  Assert
            Assert.AreEqual(yearlyBudget, department.YearlyBudget);

        }

        #endregion

        #region IsBudgetExceeded

        [TestMethod]
        public void IsBudgetExceededInDepartment()
        {
            //  Arrange
            List<Employee> employees = new List<Employee>();

            Employee emp = new Employee(/*firstname = */"Karl", /* lastnames = */ "Karlsen", /* ssn =*/ "2009931234",
                /* monthlyBaseSalary = */ 100m, /* monthlyBonusSalary = */ 10m, /* christmasBonus = */ 1m);
            Employee temp = new Employee("Ib", "Ibsen", "2009931234", 5000m, 10m, 500m);

            employees.Add(emp);
            employees.Add(temp);

            decimal yearlyBudget = 10m;
            decimal expectedPayout = 40261.65m;

            //  Act
            Department department = new Department(employees, yearlyBudget);
            
            //  Assert
            Assert.AreEqual(expectedPayout, department.YearlyPayout);
            Assert.AreEqual(true, department.IsBudgetExceeded);
        }

        #endregion

        #region Add

        [TestMethod]
        public void Add()
        {
            //  Arrange
            List<Employee> employees = new List<Employee>();

            Employee emp = new Employee("Karl", "Karlsen", "2009931234", 100m, 10m, 1m);
            Employee temp = new Employee("Ib", "Ibsen", "2009931234", 5000m, 10m, 500m);
            Employee newEmployee = new Employee("Børge", "Børgesen", "253453", 12000m, 3423m, 232423m);
            decimal yearlyBudget = 10m;

            //  Act
            employees.Add(emp);
            employees.Add(temp);

            Department department = new Department(employees, yearlyBudget);
            department.Add(newEmployee);
            employees.Add(newEmployee);

            //  Assert
            Assert.AreEqual(employees.Count, department.Employees.Count);
        }

        #endregion

        #region GetEmployeeBy

        [TestMethod]
        public void GetEmployeeBySsn()
        {
            //  Arrange
            List<Employee> employees = new List<Employee>();

            string ssn = "2009931234";

            Employee emp = new Employee("Karl", "Karlsen", ssn, 100m, 10m, 1m);
            Employee temp = new Employee("Ib", "Ibsen", "2009931234", 5000m, 10m, 500m);
            decimal yearlyBudget = 10m;

            //  Act
            employees.Add(emp);
            employees.Add(temp);

            Department department = new Department(employees, yearlyBudget);

            //  Assert
            Assert.AreEqual(emp, department.GetEmployeeBy(ssn));
        }

        [TestMethod]
        public void GetEmployeeByName()
        {
            //  Arrange
            List<Employee> employees = new List<Employee>();

            string firstname = "Karl";
            string lastnames = "Karlsen";

            Employee emp = new Employee(firstname, lastnames, "2009931234", 100m, 10m, 1m);
            Employee temp = new Employee("Ib", "Ibsen", "2009931234", 5000m, 10m, 500m);
            decimal yearlyBudget = 10m;

            //  Act
            employees.Add(emp);
            employees.Add(temp);

            Department department = new Department(employees, yearlyBudget);

            //  Assert
            Assert.AreEqual(emp, department.GetEmployeeBy(firstname, lastnames));
        }

        #endregion

        #region Remove

        [TestMethod]
        public void Remove()
        {
            //  Arrange
            List<Employee> employees = new List<Employee>();

            Employee emp = new Employee("Karl", "Karlsen", "2009931234", 100m, 10m, 1m);
            Employee temp = new Employee("Ib", "Ibsen", "2009931234", 5000m, 10m, 500m);
            Employee newEmployee = new Employee("Børge", "Børgesen", "253453", 12000m, 3423m, 232423m);
            decimal yearlyBudget = 10m;

            //  Act
            employees.Add(emp);
            employees.Add(temp);

            Department department = new Department(employees, yearlyBudget);
            department.Add(newEmployee);
            employees.Add(newEmployee);

            department.Remove(newEmployee);
            employees.Remove(newEmployee);
            //  Assert
            Assert.AreEqual(employees.Count, department.Employees.Count);
        }

        #endregion

        #region BudgetExcession

        [TestMethod]
        public void BudgetExcession()
        {
            //  Arrange
            List<Employee> employees = new List<Employee>();

            Employee emp = new Employee("Karl", "Karlsen", "2009931234", 100m, 10m, 1m);
            Employee temp = new Employee("Ib", "Ibsen", "2009931234", 5000m, 10m, 500m);

            employees.Add(emp);
            employees.Add(temp);

            decimal yearlyBudget = 1000m;
            decimal expectedPayout = 40261.65m;
            decimal expectedBudgetExcess;
            bool expectedexcession = true;

            //  Act
            Department department = new Department(employees, yearlyBudget);

            expectedBudgetExcess = yearlyBudget - expectedPayout;

            //  Assert
            Assert.AreEqual(yearlyBudget, department.YearlyBudget);
            Assert.AreEqual(expectedexcession, department.IsBudgetExceeded);
        } 

        #endregion
    }
}
