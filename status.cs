using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2011_PROJECT.Business
{
    public class Status
    {
        /*The Role class will have a role description(description) and the role ID(roleval) 
            * which can either be: runner, headwaitron, waitron or simply no role.
            * These data members could be reused by the child classes, 
            * so be mindful of the protection rights you give them.
            */

        #region Data Member
        public enum StatusType
        {
            /*The role ID will be stored as an enumeration type. 
             So an employee can either have no role, that is, not yet assigned (0), be a Headwaiter (1), a Waiter (2) 
             or a Runner (3). Once you declare the role type as an enumeration type, make sure the role ID (roleval) 
             is of this type (RoleType).  */
            NoStatus = 0,
            VVIP = 1,
            VIP = 2,
            RegularGuest = 3
        }
        protected StatusType statusValue;
        protected string description;

        #endregion

        #region Property Methods
        /*Declare properties for the Role class	*/
        public StatusType getStatusValue
        {
            get { return statusValue; }
            set { statusValue = value; }
        }
        public string getDescription
        {
            get { return description; }
            set { description = value; }
        }
        #endregion

        #region Constructor
        /*Include a default constructor to initialise the values: 
         * Initialise the StatusValue and the status description to no role. 
         * We assume until a role is assigned to an employee, they have no role
         */

        public Status()
        {
            statusValue = status.StatusType.NoStatus;
            description = "No role";
        }
        #endregion

         region Methods

        public virtual decimal Payment()
        {
            /*Include an overridable method Payment() which is to return the salary.
            * For now the method will return 0;       */
            return 0;
        }

        public virtual decimal Payment(decimal percentage)
        {
            /*Include another overridable method Payment() which takes in an argument
             and returns the salary. */
            return 0;
        }

        #endregion
    }
}
