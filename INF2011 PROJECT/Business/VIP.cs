using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2011_PROJECT.Business
{
    public  VIP : status
    {

    #region Data Member
    private int security;
    private decimal discount;
    #endregion

    #region Property Methods
    public int getSecurity 
    {
        get { return security; }
        set { security = value; }
            
    }

    public decimal getDiscount
    {
        get { return discount; }
        set { discount = value; }

    }
    #endregion

    #region Constructors
    public VIP() : base()
    {
            getStatusValue = statusType.VIP;
            description = "VIP";
            discount = 0.1;
            security=2
            
    }
    #endregion

    #region Methods
    public override decimal Payment()
    {
    //Will be calculated when shifts are available
    return 5000;
    }
    #endregion

    }
}
