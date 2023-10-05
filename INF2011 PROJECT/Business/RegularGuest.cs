using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IN2011_PROJECT.Business
{
    public class RegularGuest : Status
    {
        #region Data Member
        //encapsulation
        private string welcomeGift;
        #endregion

        #region Property Methods
        public string welcomeGift
        {
            get { return welcomeGift; }
            set { welcomeGift = value; }

        }
        #endregion

        #region Constructors
        public VIP() : base()
        {
            getStatusValue = statusType.RegularGuest;
            description = "RegularGuest";
            welcomeGift="Sweet"
    

        }
        #endregion

    }

}