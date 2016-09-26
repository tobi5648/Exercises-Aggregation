using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Entities
{
    public class Department
    {
        //  Heres the variables
        #region Variables

        #region Custom variables

        decimal yearleyPayout;
        decimal monthleyPayout;
        decimal topTax = 467300m;
        decimal monthlyUnderTopTax;
        decimal monthlyOverTopTax;
        decimal totalYearleyPayout;
        decimal totalMonthleyPayout;
        decimal yearlyUnderTopTax;
        decimal yearlyOverTopTax;
        decimal yearlytopTax;
        decimal topTaxRate = 0.15m;
        decimal underTopTaxRate = 0.35m;
        decimal budgetExcession;

        #endregion

        #region Fields

        /// <summary>
        /// The List of employees in the department
        /// </summary>
        private List<Employee> employees;

        /// <summary>
        /// The yearly budget
        /// </summary>
        private decimal yearlyBudget;

        /// <summary>
        /// Determines if the budget has been kept
        /// </summary>
        private bool isBudgetExceeded;

        #endregion

        #region Properties

        /// <summary>
        /// Gets the list of employees and makes it read only
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">It couldn't be converted</exception>
        public IReadOnlyList<Employee>  Employees
        {
            get
            {
                try
                {
                    return employees;
                }
                catch (ArgumentOutOfRangeException)
                {
                    throw new ArgumentOutOfRangeException("The list couldnt be converted");
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        /// <summary>
        /// Gets or sets if the budget is exceeeded
        /// </summary>
        public bool IsBudgetExceeded
        {
            get
            {
                return isBudgetExceeded;
            }
            set
            {
                if (yearleyPayout > yearlyBudget)
                    value = true;
                else if (yearlyBudget > yearleyPayout)
                    value = false;
            }
        }

        /// <summary>
        /// Gets the monthly payout to the employees total
        /// </summary>
        public  decimal MonthlyPayout
        {
            get
            {//Top: 37% + 15% af det der er over.
                //FØr: 37%
                CalculateMonthlyPayout();
                return totalMonthleyPayout;
            }
        }

        /// <summary>
        /// Gets the yearly payout to the employees
        /// </summary>
        public decimal YearlyPayout
        {
            get
            {
                try
                {
                    yearlytopTax = topTax * 12;
                    totalYearleyPayout = 0;

                    foreach (var e in Employees)
                    {
                        yearleyPayout = 0m;
                        yearleyPayout = e.GetYearlyPayout();

                        if (yearleyPayout > yearlytopTax)
                        {
                            yearlyOverTopTax = yearleyPayout - yearlytopTax;
                            yearlyUnderTopTax = yearleyPayout - yearlyOverTopTax;

                            yearlyOverTopTax = yearlyOverTopTax - (yearlyOverTopTax * topTaxRate);
                            yearlyUnderTopTax = yearlyUnderTopTax - (yearlyUnderTopTax * underTopTaxRate);

                            yearleyPayout = yearlyOverTopTax + yearlyUnderTopTax;
                            totalYearleyPayout += yearleyPayout;
                        }
                        else if (yearleyPayout < topTax)
                        {
                            yearleyPayout = yearleyPayout - (yearleyPayout * underTopTaxRate);
                            totalYearleyPayout += yearleyPayout;
                        }
                    }
                    CalculateBudgetExcession();
                    return totalYearleyPayout;
                }
                catch (ArgumentOutOfRangeException)
                {
                    throw new ArgumentOutOfRangeException();
                }
                catch (Exception)
                {
                    throw new Exception();
                }
            }
        }

        /// <summary>
        /// Gets or sets the yearly budget
        /// </summary>
        public decimal YearlyBudget
        {
            get
            {
                yearleyPayout = YearlyPayout;
                CalculateBudgetExcession();
                
                return yearlyBudget;
            }
            set
            {
                yearlyBudget = value;
                CalculateBudgetExcession();
            }
        }

        #endregion

        #endregion

        //  Heres the methods
        #region Methods

        #region Main Methods
        
        /// <summary>
        /// Adds an employee to the department
        /// </summary>
        /// <param name="employee"></param>
        public void Add (Employee employee)
        {
            employees.Add(employee);
        }        

        /// <summary>
        /// Gets an employee by a specified social security number
        /// </summary>
        /// <param name="firstnames"></param>
        /// <returns></returns>
        public Employee GetEmployeeBy(string ssn)
        {
            Employee ssnEmployee = null;

            foreach (var e in Employees)
            {
                if (e is Employee)
                {
                    if (e.Ssn == ssn)
                    {
                        ssnEmployee = e;
                        return ssnEmployee;
                    }
                }
            }
            return ssnEmployee;
        }

        /// <summary>
        /// Gets an employee by full name
        /// </summary>
        /// <param name="firstnames"></param>
        /// <returns></returns>
        public Employee GetEmployeeBy(string firstnames, string lastnames)
        {
            Employee nameEmployee = null;

            foreach (var e in Employees)
            {
                if (e is Employee)
                {
                    if (e.Firstname == firstnames)
                    {
                        if (e.Lastnames == lastnames)
                        {
                            nameEmployee = e;
                            return nameEmployee;
                        }
                    }
                }
            }
            return nameEmployee;
        }

        /// <summary>
        /// Removes the specified employee
        /// </summary>
        /// <param name="employee"></param>
        public void Remove (Employee employee)
        {
            employees.Remove(employee);
        }

        /// <summary>
        /// Calculates the budget and sees if it is exceeded
        /// </summary>
        private void CalculateBudgetExcession()
        {

            budgetExcession = 0;

            budgetExcession = yearlyBudget - totalYearleyPayout;

            if (budgetExcession < 0)
                isBudgetExceeded = true;
            if (budgetExcession > 0)
                isBudgetExceeded = false;
        }

        /// <summary>
        /// Calculates the monthley payout
        /// </summary>
        private void CalculateMonthlyPayout()
        {
            try
            {

                totalMonthleyPayout = 0;

                foreach (var e in Employees)
                {
                    monthleyPayout = 0m;
                    monthleyPayout = e.GetMonthlyPayout();

                    if (yearleyPayout > topTax)
                    {
                        monthlyOverTopTax = monthleyPayout - topTax;
                        monthlyUnderTopTax = monthleyPayout - monthlyOverTopTax;

                        monthlyOverTopTax = monthlyOverTopTax - (monthlyOverTopTax * topTaxRate);
                        monthlyUnderTopTax = monthlyUnderTopTax - (monthlyUnderTopTax * underTopTaxRate);

                        monthleyPayout = monthlyOverTopTax + monthlyUnderTopTax;
                        totalMonthleyPayout += monthleyPayout;
                    }
                    else if (monthleyPayout < topTax)
                    {
                        monthleyPayout = monthleyPayout - (monthleyPayout * underTopTaxRate);
                        totalMonthleyPayout += monthleyPayout;
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                throw new ArgumentOutOfRangeException();
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// The constructor for the department, containing the employees
        /// </summary>
        /// <param name="employees"></param>
        /// <param name="yearlyBudget"></param>
        public Department(List<Employee> employees, decimal yearlyBudget)
        {
            this.employees = employees;
            YearlyBudget = yearlyBudget;
        }

        #endregion

        #endregion
    }
}
