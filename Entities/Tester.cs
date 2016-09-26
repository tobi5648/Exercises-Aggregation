using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    /// <summary>
    /// This is the testers
    /// </summary>
    class Tester : Employee
    {
        //  This is the variables used in the class
        #region Variables

        //  This is the custom variables used in the class
        #region Custom variables

        /// <summary>
        /// The name of the tester
        /// </summary>
        string name;

        #endregion

        //  Heres the fields used in the class
        #region Fields

        /// <summary>
        /// The expertise of the tester
        /// </summary>
        private Expertise expertise;

        #endregion

        //  Heres the properties for the fields used in the class
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

        //  The methods used in the class
        #region Methods

        //  These sets fields in the class
        #region Setters
        
        /// <summary>
        /// Sets the expertise of the tester
        /// </summary>
        private void SetExpertise()
        {
            if (name == "Karl")
                Expertise = Expertise.Software;
        }

        #endregion
        
        //  Here's the constructors of the class
        #region Constructors
        
        /// <summary>
        /// The constructor for the class Tester
        /// </summary>
        /// <param name="firstname"></param>
        /// <param name="lastnames"></param>
        /// <param name="ssn"></param>
        /// <param name="monthlyBaseSalary"></param>
        /// <param name="monthlyBonusSalary"></param>
        /// <param name="christmasBonus"></param>
        /// <param name="expertise"></param>
        public Tester (string firstname, string lastnames, string ssn, decimal monthlyBaseSalary, decimal monthlyBonusSalary, decimal christmasBonus, Expertise expertise) : base(firstname, lastnames, ssn, monthlyBaseSalary, monthlyBonusSalary, christmasBonus)
        {
            name = firstname;
            Expertise = expertise;
        }
        
        #endregion

        #endregion
    }
}
