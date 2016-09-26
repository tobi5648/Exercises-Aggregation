using System;
using Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EntitiesTests
{
    /// <summary>
    /// Tests Employee
    /// </summary>
    [TestClass]
    public class EmployeeTests
    {
        //  Tests the christmas bonus
        #region Christmas bonus

        /// <summary>
        /// Tests if it will fail with a negative value
        /// </summary>
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

        /// <summary>
        /// Tests if it will pass a positive value
        /// </summary>
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

        // Tests the firstname
        #region Firstname

        /// <summary>
        /// Tests if it will fail if digits is in the name
        /// </summary>
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

        /// <summary>
        /// Tests if it will fail if the value of the name is whitespace/null
        /// </summary>
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
        
        /// <summary>
        /// Tests if a name can be given to the employee
        /// </summary>
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

        //  Tests the lastname/s
        #region Lastname/s

        /// <summary>
        /// Tests if it will fail if digits is in the name
        /// </summary>
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

        /// <summary>
        /// Tests if it will fail if the value of the name is whitespace/null
        /// </summary>
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

        /// <summary>
        /// Tests if a surname can be given to the employee
        /// </summary>
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

        //  Tests the monthly base salary
        #region MonthlyBaseSalary

        /// <summary>
        /// Tests if it will fail with a negative value
        /// </summary>
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

        /// <summary>
        /// Tests if it will pass a positive value
        /// </summary>
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

        //  Tests the monthly bonus salary
        #region MonthlyBonusSalary

        /// <summary>
        /// Tests if it will fail with a negative value
        /// </summary>
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

        /// <summary>
        /// Tests if it will pass a positive value
        /// </summary>
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

        //  Tests the social security number
        #region Social Security Number

        /// <summary>
        /// Tests if it will fail if the value is negative
        /// </summary>
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

        /// <summary>
        /// Tests if it will pass if the value is positive
        /// </summary>
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

        /// <summary>
        /// Tests if it will fail if the value is with letters
        /// </summary>
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

        /// <summary>
        /// Tests if it will fail if the value is empty
        /// </summary>
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

        //  Tests if an employee can be created
        #region Employee

        /// <summary>
        /// Tests if an employee can be created
        /// </summary>
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

        //  Tests the GetMonthlyPayout
        #region Get Monthly Payout
        
        /// <summary>
        /// tests if the monthly payout can be calculated
        /// </summary>
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

        /// <summary>
        /// tests if the monthly payout will fail if a value is negative
        /// </summary>
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

        //  Tests the GetYearlyPayout
        #region Get Yearly Payout

        /// <summary>
        /// tests if the monthly payout can be calculated
        /// </summary>
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

        /// <summary>
        /// tests if the monthly payout will fail if a value is negative
        /// </summary>
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
