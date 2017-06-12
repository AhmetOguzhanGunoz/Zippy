using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Shippers
/// </summary>
public class Shippers
{    
    /* Fields*/

    private int _ShipperID;
    private string _CompanyName;
    private long _Phone;

    /*properties*/

    public int ShipperID
    {
        get { return _ShipperID; }
        set { _ShipperID = value; }
    }

    public string CompanyName
    {
        get { return _CompanyName; }
        set { _CompanyName = value; }
    }

    public long Phone
    {
        get { return _Phone; }
        set { _Phone = value; }
    }

    /*constructor*/
	public Shippers()
	{
        ShipperID = 0;
        CompanyName = "unknown";
        Phone = 0;
	}

    //Methods

    public void Create(Shippers obj)
    {

    }

    public Shippers Read(int shipperID)
    {

        return null;
    }

    public void Update()
    {

    }

    public void Delete(int shipperID)
    {

    }
}