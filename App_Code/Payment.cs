using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Payment
/// </summary>
public class Payment
{
    /* Fields*/
    private int _PaymentID;
    private string _PaymentType;
    bool _Allowed;

    /*properties*/
    public int PaymentID
    {
        get { return _PaymentID; }
        set { _PaymentID = value; }
    }

    public string PaymentType
    {
        get { return _PaymentType; }
        set { _PaymentType = value; }
    }

    public bool Allowed
    {
        get { return _Allowed; }
        set { _Allowed = value; }
    }

    /*constructor*/
	public Payment()
	{
        PaymentID = 0;
        PaymentType = "unknown";
        Allowed = false;
	}

    //Methods

    public void Create(Payment obj)
    {

    }

    public Payment Read(int paymentID)
    {

        return null;
    }

    public void Update()
    {

    }

    public void Delete(int paymentID)
    {

    }
}