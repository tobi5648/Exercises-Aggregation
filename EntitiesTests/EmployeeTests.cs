using System;
using Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EntitiesTests
{
    [TestClass]
    public class EmployeeTests
    {

        #region Christmas bonus

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void ChristmasBonusNegative()
        {
            //  Arrange
            decimal negativeChristmasBonus = -1.0m;
            Employee employee = new Employee("Karl", "karlsen", "1", 1m, 1m, negativeChristmasBonus);

            //  Act
            employee.ChristmasBonus = negativeChristmasBonus;

            //  Assert
            Assert.AreEqual(negativeChristmasBonus, employee.ChristmasBonus);
        }

        [TestMethod]
        public void ChristmasBonusPositive()
        {
            //  Arrange
            decimal positiveChristmasBonus = 1.0m;
            Employee employee = new Employee("Karl", "karlsen", "1", 1m, 1m, positiveChristmasBonus);

            //  Act
            employee.ChristmasBonus = positiveChristmasBonus;

            //  Assert
            Assert.AreEqual(positiveChristmasBonus, employee.ChristmasBonus);
        }

        #endregion

        #region Firstname

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void FirstnameWithDigits()
        {
            //  Arrange
            string DigitFirstname = "Karl1";
            Employee employee = new Employee(DigitFirstname, "karlsen", "1", 1m, 1m, 1m);

            //  Act
            employee.Firstname = DigitFirstname;

            //  Assert
            Assert.AreEqual(DigitFirstname, employee.Firstname);
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void FirstnameWithWhitespace()
        {
            //  Arrange
            string WhitespaceFirstname = "";
            Employee employee = new Employee(WhitespaceFirstname, "karlsen", "1", 1m, 1m, 1m);

            //  Act
            employee.Firstname = WhitespaceFirstname;

            //  Assert
            Assert.AreEqual(WhitespaceFirstname, employee.Firstname);
        }
        
        [TestMethod]
        public void Firstname()
        {
            //  Arrange
            string ProperFirstname = "Karl";
            Employee employee = new Employee(ProperFirstname, "karlsen", "1", 1m, 1m, 1m);

            //  Act
            employee.Firstname = ProperFirstname;

            //  Assert
            Assert.AreEqual(ProperFirstname, employee.Firstname);
        }

        #endregion

        #region Lastname/s

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void LastnameWithDigits()
        {
            //  Arrange
            string DigitLastname = "Karlsen1";
            Employee employee = new Employee("Karl", DigitLastname, "1", 1m, 1m, 1m);

            //  Act
            employee.Lastnames = DigitLastname;

            //  Assert
            Assert.AreEqual(DigitLastname, employee.Lastnames);
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void LastnameWithWhitespace()
        {
            //  Arrange
            string WhitespaceLastname = "";
            Employee employee = new Employee("Karl", WhitespaceLastname, "1", 1m, 1m, 1m);

            //  Act
            employee.Lastnames = WhitespaceLastname;

            //  Assert
            Assert.AreEqual(WhitespaceLastname, employee.Lastnames);
        }

        [TestMethod]
        public void Lastname()
        {
            //  Arrange
            string ProperLastname = "Karlsen";
            Employee employee = new Employee("Karl", ProperLastname, "1", 1m, 1m, 1m);

            //  Act
            employee.Lastnames = ProperLastname;

            //  Assert
            Assert.AreEqual(ProperLastname, employee.Lastnames);
        }

        #endregion

        #region MonthlyBaseSalary

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void MonthlyBaseSalaryNegative()
        {
            //  Arrange
            decimal negativeMonthlyBaseSalary = -1.0m;
            Employee employee = new Employee("Karl", "karlsen", "1", negativeMonthlyBaseSalary, 1m, 1m);

            //  Act
            employee.MonthlyBaseSalary = negativeMonthlyBaseSalary;

            //  Assert
            Assert.AreEqual(negativeMonthlyBaseSalary, employee.MonthlyBaseSalary);
        }

        [TestMethod]
        public void MonthlyBaseSalaryPositive()
        {
            //  Arrange
            decimal positiveMonthlyBaseSalary = 1.0m;
            Employee employee = new Employee("Karl", "karlsen", "1", positiveMonthlyBaseSalary, 1m, 1m);

            //  Act
            employee.MonthlyBaseSalary = positiveMonthlyBaseSalary;

            //  Assert
            Assert.AreEqual(positiveMonthlyBaseSalary, employee.MonthlyBaseSalary);
        }

        #endregion

        #region MonthlyBonusSalary

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void MonthlyBonusSalaryNegative()
        {
            //  Arrange
            decimal negativeMonthlyBonusSalary = -1.0m;
            Employee employee = new Employee("Karl", "karlsen", "1", 1m, negativeMonthlyBonusSalary, 1m);

            //  Act
            employee.MonthlyBonusSalary = negativeMonthlyBonusSalary;

            //  Assert
            Assert.AreEqual(negativeMonthlyBonusSalary, employee.MonthlyBonusSalary);
        }

        [TestMethod]
        public void MonthlyBonusSalaryPositive()
        {
            //  Arrange
            decimal positiveMonthlyBonusSalary = 1.0m;
            Employee employee = new Employee("Karl", "karlsen", "1", 1m, positiveMonthlyBonusSalary, 1m);

            //  Act
            employee.MonthlyBonusSalary = positiveMonthlyBonusSalary;

            //  Assert
            Assert.AreEqual(positiveMonthlyBonusSalary, employee.MonthlyBonusSalary);
        }

        #endregion

        #region Social Security Number

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void SsnNegative()
        {
            //  Arrange
            string negativessn = "-2009931234";
            Employee employee = new Employee("Karl", "karlsen", negativessn, 1m, 1m, 1m);

            //  Act
            employee.Ssn = negativessn;

            //  Assert
            Assert.AreEqual(negativessn, employee.Ssn);
        }

        [TestMethod]
        public void SsnPositive()
        {
            //  Arrange
            string positivessn = "2009931234";
            Employee employee = new Employee("Karl", "karlsen", positivessn, 1m, 1m, 1m);

            //  Act
            employee.Ssn = positivessn;

            //  Assert
            Assert.AreEqual(positivessn, employee.Ssn);
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void SsnLetters()
        {
            //  Arrange
            string letterSsn = "A2009931234";
            Employee employee = new Employee("Karl", "karlsen", letterSsn, 1m, 1m, 1m);

            //  Act
            employee.Ssn = letterSsn;

            //  Assert
            Assert.AreEqual(letterSsn, employee.Ssn);
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void SsnEmpty()
        {
            //  Arrange
            string emptySsn = "";
            Employee employee = new Employee("Karl", "karlsen", emptySsn, 1m, 1m, 1m);

            //  Act
            employee.Ssn = emptySsn;

            //  Assert
            Assert.AreEqual(emptySsn, employee.Ssn);
        }


        #endregion

        #region Employee
        
        [TestMethod]
        public void Employee()
        {
            //  Arrange
            decimal christmasBonus = 1m;
            string firstname = "Karl";
            string lastnames = "Karlsen";
            decimal monthlyBaseSalary = 100m;
            decimal monthlyBonusSalary = 10m;
            string ssn = "2009931234";

            Employee employee = new Employee(firstname, lastnames, ssn, monthlyBaseSalary, monthlyBonusSalary, christmasBonus);

            //  Act
            employee.ChristmasBonus = christmasBonus;
            employee.Firstname = firstname;
            employee.Lastnames = lastnames;
            employee.MonthlyBaseSalary = monthlyBaseSalary;
            employee.MonthlyBonusSalary = monthlyBonusSalary;
            employee.Ssn = ssn;

            //  Assert
            Assert.AreEqual(christmasBonus, employee.ChristmasBonus );
            Assert.AreEqual(firstname, employee.Firstname);
            Assert.AreEqual(lastnames, employee.Lastnames);
            Assert.AreEqual(monthlyBaseSalary, employee.MonthlyBaseSalary);
            Assert.AreEqual(monthlyBonusSalary, employee.MonthlyBonusSalary);
            Assert.AreEqual(ssn, employee.Ssn);
        }

        #endregion

        #region Get Monthly Payout
        
        [TestMethod]
        public void GetMonthlyPayout()
        {
            //  Arrange
            decimal monthlyBaseSalary = 100m;
            decimal monthlyBonusSalary = 10m;
            decimal payout;
            decimal expectedPayout = 110m;
            Employee employee = new Employee("Karl", "karlsen", "1", monthlyBaseSalary, monthlyBonusSalary, 2m);

            //  Act
            employee.MonthlyBaseSalary = monthlyBaseSalary;
            employee.MonthlyBonusSalary = monthlyBonusSalary;

            payout = employee.GetMonthlyPayout();

            //  Assert
            Assert.AreEqual(expectedPayout, payout);
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void GetMonthlyPayoutFail()
        {
            //  Arrange
            decimal monthlyBaseSalary = 100m;
            decimal monthlyBonusSalary = -10m;
            decimal payout;
            decimal expectedPayout = 90m;
            Employee employee = new Employee("Karl", "karlsen", "1", monthlyBaseSalary, monthlyBonusSalary, 2m);

            //  Act
            employee.MonthlyBaseSalary = monthlyBaseSalary;
            employee.MonthlyBonusSalary = monthlyBonusSalary;

            payout = employee.GetMonthlyPayout();

            //  Assert
            Assert.AreEqual(expectedPayout, payout);
            Assert.AreEqual(monthlyBaseSalary, employee.MonthlyBaseSalary);
            Assert.AreEqual(monthlyBonusSalary, employee.MonthlyBonusSalary);
        }

        #endregion

        #region Get Yearly Payout

        [TestMethod]
        public void GetYearlyPayout()
        {
            //  Arrange
            decimal monthlyBaseSalary = 100m;
            decimal monthlyBonusSalary = 10m;
            decimal christmasBonus = 1m;
            decimal payout;
            decimal expectedPayout = 1321m;
            Employee employee = new Employee("Karl", "karlsen", "1", monthlyBaseSalary, monthlyBonusSalary, christmasBonus);

            //  Act
            employee.MonthlyBaseSalary = monthlyBaseSalary;
            employee.MonthlyBonusSalary = monthlyBonusSalary;
            employee.ChristmasBonus = christmasBonus;

            payout = employee.GetYearlyPayout();

            //  Assert
            //  Assert
            Assert.AreEqual(expectedPayout, payout);
            Assert.AreEqual(monthlyBaseSalary, employee.MonthlyBaseSalary);
            Assert.AreEqual(monthlyBonusSalary, employee.MonthlyBonusSalary);
            Assert.AreEqual(christmasBonus, employee.ChristmasBonus);
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void GetYearlyPayoutFail()
        {
            //  Arrange
            decimal monthlyBaseSalary = -100m;
            decimal monthlyBonusSalary = -10m;
            decimal christmasBonus = -1m;
            decimal payout;
            decimal expectedPayout = -1321m;
            Employee employee = new Employee("Karl", "karlsen", "1", monthlyBaseSalary, monthlyBonusSalary, christmasBonus);

            //  Act

            payout = employee.GetYearlyPayout();

            //  Assert
            Assert.AreEqual(expectedPayout, payout);
            Assert.AreEqual(monthlyBaseSalary, employee.MonthlyBaseSalary);
            Assert.AreEqual(monthlyBonusSalary, employee.MonthlyBonusSalary);
            Assert.AreEqual(christmasBonus, employee.ChristmasBonus);
        }

        #endregion
    }
}
