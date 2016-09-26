using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department
{
    public class Department
    {

        #region Variables

        #region Fields

        /// <summary>
        /// The List of employees in the department
        /// </summary>
        private List<Employee> employees;

        /// <summary>
        /// 
        /// </summary>
        private decimal yearlyBudget;

        #endregion
//  Test to comment
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

        #endregion

        #endregion

        #region Constructors

        /// <summary>
        /// The constructor for the department
        /// </summary>
        /// <param name="employees"></param>
        /// <param name="yearlyBudget"></param>
        public Department(List<Employee> employees, decimal yearlyBudget)
        {
            this.employees = employees;
            this.yearlyBudget = yearlyBudget;
        }

        public Department()
        {
            
        }

        #endregion
    }
}
