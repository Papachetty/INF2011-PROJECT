using System;

public  class Person
{
    #region Datamembers
    private string id;
	private string name;
	private string phoneNumber;
    #endregion

    #region Constructors
    public Person(string Name,string ID, string phoneNumber)
	{
		this.id = ID;
		this.name = Name;
		this.phoneNumber = phoneNumber;
	}

	public Person()
	{
		ID = "No ID, please fill in one";
		Name = "No name, please fill in one";
		phoneNumber = "No phone number, please fill in one";
	}
    #endregion

    #region Property methods
    public string ID
	{ 
	get { return id; }
	set { id = value; }
	
	}
	public string Name
	{ 
	  get { return name; } 
	  set {  name = value; } 
	}
	public string PhoneNumber
	{ 
		get { return phoneNumber; }
		set { phoneNumber = value; }
	}
	#endregion

	#region toString
	public string toString() 
	{ 
	return this.name +"'s Phone number is "+ this.phoneNumber;
	
	}
	#endregion



}
