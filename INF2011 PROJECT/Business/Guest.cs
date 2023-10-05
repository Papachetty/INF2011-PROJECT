using System;

public class Guest: Person
{
    #region data members
    private string guestNumber, roomType, accesslevel, snackstatus,;
	private status guestType;
    #endregion


    #region Property methods
    public string GuestNumber() 
	{
		get{ return guestNumber; }
		set{ guestNumber = value; }
	}
	public string GuestType() 
	{
		get { return guestType; }
		set { return guestNumber; }
	
	}

    public string getRoomType
    {
        get { return roomType; }
        set { roomType = value; }
    }

    public string getAccessLevel
    {
        get { return accesslevel; }
        set { accesslevel = value; }
    }

    public string getSnackStatus
    {
        get { return snackstatus; }
        set { snackstatus = value; }
    }
    #endregion

    #region Constructor
    /*
     * Include the constructor of the class. 							
        The constructor should have one argument statusValue of type Status. 
        This is because upon the invocation of this class, the Status of the Guest should be determined.
        Use a switch statement to find the specific Status as follows (for more on switch statements):
        If there is no role yet, then:                  Status = new Status ();
        If the role is VVIP, then:	    	status = new VVIP ();

     */
    public Guest()
    {
        this.guestNumber = null;
        this.guestType = null;

    }

    public Guest(status.StatusType statusValue)
    {
        switch (statusValue)
        {
            case status.StatusType.NoStatus:
                statusValue = new Status();
                roomType = "No room assigned.";
                accesslevel = "No access level";
                snackstatus = "No snack status";
                break;
            case status.StatusType.VVIP:
                statusValue = new VVIP();
                roomType = "Deluxe suite";
                accesslevel = "Total Access";
                snackstatus = "Unlimited";
                break;
            case status.StatusType.VIP:
                statusValue = new VIP();
                roomType = "Luxury room";
                accesslevel = "Special Acess";
                snackstatus = "limited snacks";
                break;
            case status.StatusType.RegularGuest:
                statusValue = new RegularGuest();
                roomType = "Standard room";
                accesslevel = "Standard access";
                snackstatus = "Paid for";
                break;
        }
       
    }
    #endregion

}
