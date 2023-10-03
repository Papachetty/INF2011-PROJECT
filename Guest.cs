using System;

public class Guest: Person
{	

	private string guestNumber;
	private status guestType;
	public Class1()
	{
	}

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

    #region Constructor
    /*
     * Include the constructor of the class. 							
        The constructor should have one argument roleValue of type Role. 
        This is because upon the invocation of this class, the role of the employee should be determined.
        Use a switch statement to find the specific role as follows (for more on switch statements):
        If there is no role yet, then:                  role = new Role ();
        If the role is Headwaiter, then:	    	role = new HeadWaiter ();

     */

    public Employee(status.StatusType statusValue)
    {
        switch (statusValue)
        {
            case status.StatusType.NoStatus:
                role = new Role();
                break;
            case status.StatusType.VVIP:
                statusValue = new VVIP();
                break;
            case status.StatusType.VIP:
                statusValue = new VIP();
                break;
            case status.StatusType.RegularGuest:
                statusValue = new RegularGuest();
                break;
        }
    }
    #endregion

}
