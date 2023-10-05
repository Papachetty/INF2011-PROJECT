using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2011_PROJECT.Business
{
    public class HeadWaiter : Role
    {
        #region Data Member
        //encapsulation
        private string specialEvents,view;
        private int police
        #endregion

        #region Property Methods

        public string getSpecialEvents
        {
            get { return specialEvents; }
            set { specialEvents = value; }
        }

        public string getView
        {
            get { return view; }
            set { view = value; }
        }

        public int getPolice
        {
            get { return police; }
            set { police = value; }
        }

        #endregion

        #region Constructor
        public VVIP() : base()
        {
            getStatusValue = StatusType.VVIP;
            description = "VVIP";
            specialEvents ="Guest Welcome Event, Celebrity singer Event, Games night, proudly south African Dance night"
            police= 2;//2 bodyguards per VVIP
            view = "Bestview";
        }
        #endregion

        #region Methods
        public override decimal Payment()
        {
            //cost per VVIP person
            return 11000;
        }
        #endregion
    }
}s