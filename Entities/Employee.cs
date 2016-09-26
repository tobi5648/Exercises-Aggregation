using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    /// <summary>
    /// This is the employee from the department
    /// </summary>
    public class Employee
    {
        //  Heres the variables
        #region Variables
        
        //  Heres the constants used in the class
        #region Constants

        /// <summary>
        /// the taxloft
        /// </summary>
        private const decimal TopTaxLimit = 467300m;

        /// <summary>
        /// the taxrate loft
        /// </summary>
        private const double TopTaxRate = 0.15;

        /// <summary>
        /// The tax rate for the employee
        /// </summary>
        private const double NormalTaxRate = 0.37;

        #endregion
        
        //  Heres the fields that will store the data
        #region Fields

        /// <summary>
        /// The christmas the employee can acquire
        /// </summary>
        private decimal christmasBonus;

        /// <summary>
        /// The firstname of the employee
        /// </summary>
        private string firstname;

        /// <summary>
        /// The employees lastnames
        /// </summary>
        private string lastnames;

        /// <summary>
        /// the employees monthly salary
        /// </summary>
        private decimal monthlyBaseSalary;

        /// <summary>
        /// The bonus salary of the employee
        /// </summary>
        private decimal monthlyBonusSalary;

        /// <summary>
        /// The social security number of the employee
        /// </summary>
        private string ssn;

        #endregion

        //  Here the fields gets and sets the values
        #region Properties

        /// <summary>
        /// Gets or sets the employees christmas bonus
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Throw this if argument/value is negative</exception>
        public decimal ChristmasBonus
        {
            get
            {
                return christmasBonus;
            }
            set
            {
                //  If the value is negative, it will fail
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("This is impossible");
                }
                else if (christmasBonus != value)
                {
                    christmasBonus = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the employees firstname
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Throw this if argument/value is not a proper name</exception>
        public string Firstname
        {
            get
            {
                return firstname;
            }

            set
            {
                //  If the firstname contains any numbers or is empty, then it fails
                if (value.Any(char.IsDigit))
                {
                    throw new ArgumentOutOfRangeException("Name doesnt include digits");
                }
                else if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException("Name doesnt include digits");
                }
                else
                {
                    firstname = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the employees lastname/s
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Throw this if argument/value is not a proper name</exception>
        public string Lastnames
        {
            get
            {
                return lastnames;
            }

            set
            {
                //  If the firstname contains any numbers or is empty, then it fails
                if (value.Any(char.IsDigit))
                {
                    throw new ArgumentOutOfRangeException("Name doesnt include digits");
                }
                else if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException("Name doesnt include digits");
                }
                else
                {
                    lastnames = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the employees  monthly basic salary
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Throw this if argument/value is not a proper negative</exception>
        public decimal MonthlyBaseSalary
        {
            get
            {
                return monthlyBaseSalary;
            }

            set
            {
                //  If the value is negative, it will fail
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("This is impossible");
                }
                else if (monthlyBaseSalary != value)
                {
                    monthlyBaseSalary = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the employees  monthly bonus salary
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Throw this if argument/value is not a proper negative</exception>
        public decimal MonthlyBonusSalary
        {
            get
            {
                return monthlyBonusSalary;
            }

            set
            {
                //  If the value is negative, it will fail
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("This is impossible");
                }
                else if (monthlyBonusSalary != value)
                {
                    monthlyBonusSalary = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the employees  social security number
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Throw this if argument/value is not a proper number</exception>
        public string Ssn
        {
            get
            {
                return ssn;
            }

            set
            {
                if (value.Any(char.IsLetter))
                {
                    throw new ArgumentOutOfRangeException("ssn doesnt include letters");
                }
                else if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException("ssn have to include digits");
                }
                else if (Convert.ToInt32(value) < 0)
                {
                    throw new ArgumentOutOfRangeException("ssn have to include digits");
                }
                else if (value.Any(char.IsDigit))
                {
                    ssn = value;
                }
            }
        }

        #endregion

        #endregion

        //  Heres the methods
        #region Methods

        #region Constructors

        /// <summary>
        /// The constructor for the employee
        /// </summary>
        /// <param name="firstname"></param>
        /// <param name="lastnames"></param>
        /// <param name="ssn"></param>
        /// <param name="monthlyBaseSalary"></param>
        /// <param name="christmasBonus"></param>
        /// <exception cref="ArgumentOutOfRangeException">It wasn't filled properly</exception>
        public Employee(string firstname, string lastnames, string ssn, decimal monthlyBaseSalary,decimal monthlyBonusSalary, decimal christmasBonus)
        {
            try
            {
                Firstname = firstname;
                Lastnames = lastnames;
                Ssn = ssn;
                MonthlyBaseSalary = monthlyBaseSalary;
                MonthlyBonusSalary = monthlyBonusSalary;
                ChristmasBonus = christmasBonus;
            }
            catch (ArgumentOutOfRangeException)
            {
                throw;
            }
            catch (ArgumentException)
            {
                throw;
            }
        }

        #endregion

        #region Payouts

        /// <summary>
        /// Calculates the employees monthly payout
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException">If it cant be calculated</exception>
        public decimal GetMonthlyPayout()
        {
            try
            {
                return monthlyBaseSalary + monthlyBonusSalary;
            }
            catch
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>
        /// Calculates the employees yearly payout
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException">If it cant be calculated</exception>
        public decimal GetYearlyPayout()
        {
            try
            {
                return (GetMonthlyPayout() * 12) + christmasBonus;
            }
            catch
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        #endregion

        #endregion
    }
}
