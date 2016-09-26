using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Tester : Employee
    {
        #region Variables

        #region Fields

        /// <summary>
        /// The expertise of the tester
        /// </summary>
        private Expertise expertise;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the expertise of the tester
        /// </summary>
        protected Expertise Expertise
        {
            get
            {
                return expertise;
            }

            set
            {
                expertise = value;
            }
        }

        #endregion

        #endregion

        #region Methods

        #region

        #endregion
        
        #region Constructors

        public Tester (string firstname, string lastnames, string ssn, decimal monthlyBaseSalary, decimal monthlyBonusSalary, decimal christmasBonus, Expertise expertise) : base(firstname, lastnames, ssn, monthlyBaseSalary, monthlyBonusSalary, christmasBonus)
        {
            Expertise = expertise;
        }
        
        #endregion

        #endregion
    }
}
