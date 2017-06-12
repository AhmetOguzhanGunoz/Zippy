using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Suppliers
/// </summary>
public class Suppliers
{    
    /* Fields*/

    private int _SupplierID;
    private string _CompanyName;
    private string _ContactFName;
    private string _ContactLName;
    private string _ContactTitle;
    private string _Adress1;
    private string _Adress2;
    private string _City;
    private string _State;
    private int _PostalCode;
    private string _Country;
    private string _Phone;
    private string _Fax;
    private string _Email;
    private string _URL;
    private string _PaymentMethods;
    private string _DiscountType;
    private string _TypeGoods;
    private string _Notes;
    private bool _DiscountAvailable;
    private string _CurrentOrder;
    private byte[] _Logo;
    private int _CustomerID;
    private string _SizeURL;


    /*properties*/
 
    public int SupplierID
    {
        get { return _SupplierID; }
        set { _SupplierID = value; }
    }
    
    public string CompanyName
    {
        get { return _CompanyName; }
        set { _CompanyName = value; }
    }
    
    public string ContactFName
    {
        get { return _ContactFName; }
        set { _ContactFName = value; }
    }

    public string ContactLName
    {
        get { return _ContactLName; }
        set { _ContactLName = value; }
    }

    public string ContactTitle
    {
        get { return _ContactTitle; }
        set { _ContactTitle = value; }
    }

    public string Adress1
    {
        get { return _Adress1; }
        set { _Adress1 = value; }
    }

    public string Adress2
    {
        get { return _Adress2; }
        set { _Adress2 = value; }
    }

    public string City
    {
        get { return _City; }
        set { _City = value; }
    }

    public string State
    {
        get { return _State; }
        set { _State = value; }
    }

    public int PostalCode
    {
        get { return _PostalCode; }
        set { _PostalCode = value; }
    }

    public string Country
    {
        get { return _Country; }
        set { _Country = value; }
    }

    public string Phone
    {
        get { return _Phone; }
        set { _Phone = value; }
    }

    public string Fax
    {
        get { return _Fax; }
        set { _Fax = value; }
    }

    public string Email
    {
        get { return _Email; }
        set { _Email = value; }
    }

    public string URL
    {
        get { return _URL; }
        set { _URL = value; }
    }

    public string PaymentMethods
    {
        get { return _PaymentMethods; }
        set { _PaymentMethods = value; }
    }

    public string DiscountType
    {
        get { return _DiscountType; }
        set { _DiscountType = value; }
    }

    public string TypeGoods
    {
        get { return _TypeGoods; }
        set { _TypeGoods = value; }
    }

    public string Notes
    {
        get { return _Notes; }
        set { _Notes = value; }
    }

    public bool DiscountAvailable
    {
        get { return _DiscountAvailable; }
        set { _DiscountAvailable = value; }
    }

    public string CurrentOrder
    {
        get { return _CurrentOrder; }
        set { _CurrentOrder = value; }
    }

    public byte[] Logo
    {
        get { return _Logo; }
        set { _Logo = value; }
    }

    public int CustomerID
    {
        get { return _CustomerID; }
        set { _CustomerID = value; }
    }
    
    public string SizeURL
    {
        get { return _SizeURL; }
        set { _SizeURL = value; }
    }

    /*constructor*/
	public Suppliers()
	{
        SupplierID = 0;
        CompanyName = "unknown";
        ContactFName = "unknown";
        ContactLName = "unknown";
        ContactTitle = "unknown";
        Adress1 = "unknown";
        Adress2 = "unknown";
        City = "unknown";
        State = "unknown";
        PostalCode = 0;
        Country = "unknown";
        Phone = "unknown";
        Fax = "unknown";
        Email = "unknown";
        URL = "unknown";
        PaymentMethods = "unknown";
        DiscountType = "unknown";
        TypeGoods = "unknown";
        Notes = "unknown";
        DiscountAvailable = false;
        CurrentOrder = "unknown";
        Logo = null;
        CustomerID = 0;
        SizeURL = "unknown";
	}

    //Methods

    public void Create(Suppliers obj)
    {
        
    }

    public Suppliers Read(int suppID)
    {
        
        return null;
    }

    public void Update()
    {
       
    }

    public void Delete(int suppID)
    {
        
    }
}