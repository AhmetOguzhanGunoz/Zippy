using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Customers
/// </summary>
public class Customers
{
    /* Fields*/
    private int _CustomerID;
    private string _FirstName;
    private string _LastName;
    private string _Class;
    private string _Room;
    private string _Building; 
    private string _Adress1;
    private string _Adress2; 
    private string _City;
    private string _State;
    private int _PostalCode;
    private string _Country;
    private long _Phone;
    private string _Email;
    private string _VoiceMail;
    private string _Password;
    private string _CreditCard;
    private string _CreditCardTypeID;  
    private string _CreditCardExpMon;
    private string _CreditCardExpYear;
    private string _BillingAdress;
    private string _BillingCity;
    private string _BillingRegion;
    private int _BillingPostalCode;
    private string _BillingCountry;
    private string _ShipAdress;
    private string _ShipCity;
    private string _ShipRegion;
    private int _ShipPostalCode;
    private string _ShipCountry;
    private DateTime _DateEntered;

    /*properties*/

    public int CustomerID
    {
        get { return _CustomerID; }
        set { _CustomerID = value; }
    }

    public string FirstName
    {
        get { return _FirstName; }
        set { _FirstName = value; }
    }

    public string LastName
    {
        get { return _LastName; }
        set { _LastName = value; }
    }

    public string Class
    {
        get { return _Class; }
        set { _Class = value; }
    }

    public string Room
    {
        get { return _Room; }
        set { _Room = value; }
    }

    public string Building
    {
        get { return _Building; }
        set { _Building = value; }
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

    public long Phone
    {
        get { return _Phone; }
        set { _Phone = value; }
    }

    public string Email
    {
        get { return _Email; }
        set { _Email = value; }
    }

    public string VoiceMail
    {
        get { return _VoiceMail; }
        set { _VoiceMail = value; }
    }

    public string Password
    {
        get { return _Password; }
        set { _Password = value; }
    }

    public string CreditCard
    {
        get { return _CreditCard; }
        set { _CreditCard = value; }
    }

    public string CreditCardTypeID
    {
        get { return _CreditCardTypeID; }
        set { _CreditCardTypeID = value; }
    }

    public string CreditCardExpMon
    {
        get { return _CreditCardExpMon; }
        set { _CreditCardExpMon = value; }
    }

    public string CreditCardExpYear
    {
        get { return _CreditCardExpYear; }
        set { _CreditCardExpYear = value; }
    }

    public string BillingAdress
    {
        get { return _BillingAdress; }
        set { _BillingAdress = value; }
    }

    public string BillingCity
    {
        get { return _BillingCity; }
        set { _BillingCity = value; }
    }

    public string BillingRegion
    {
        get { return _BillingRegion; }
        set { _BillingRegion = value; }
    }

    public int BillingPostalCode
    {
        get { return _BillingPostalCode; }
        set { _BillingPostalCode = value; }
    }

    public string BillingCountry
    {
        get { return _BillingCountry; }
        set { _BillingCountry = value; }
    }

    public string ShipAdress
    {
        get { return _ShipAdress; }
        set { _ShipAdress = value; }
    }

    public string ShipCity
    {
        get { return _ShipCity; }
        set { _ShipCity = value; }
    }

    public string ShipRegion
    {
        get { return _ShipRegion; }
        set { _ShipRegion = value; }
    }

    public int ShipPostalCode
    {
        get { return _ShipPostalCode; }
        set { _ShipPostalCode = value; }
    }

    public string ShipCountry
    {
        get { return _ShipCountry; }
        set { _ShipCountry = value; }
    }

    public DateTime DateEntered
    {
        get { return _DateEntered; }
        set { _DateEntered = value; }
    }


    /*constructor*/
	public Customers()
	{
        CustomerID = 0;
        FirstName = "unknown";
        LastName = "unknown";
        Class = "unknown";
        Room = "unknown";
        Building = "unknown";
        Adress1 = "unknown";
        Adress2 = "unknown"; 
        City = "unknown";
        State = "unknown";
        PostalCode = 0;
        Country = "unknown";
        Phone = 0;
        Email = "unknown";
        VoiceMail = "unknown";
        Password = "unknown";
        CreditCard = "unknown";
        CreditCardTypeID = "unknown";  
        CreditCardExpMon = "unknown";
        CreditCardExpYear = "unknown";
        BillingAdress = "unknown";
        BillingCity = "unknown";
        BillingRegion = "unknown";
        BillingPostalCode = 0;
        BillingCountry = "unknown";
        ShipAdress = "unknown";
        ShipCity = "unknown";
        ShipRegion = "unknown";
        ShipPostalCode = 0;
        ShipCountry = "unknown";
        DateEntered = new DateTime(0, 0, 0);
	}

    //Methods

    public void Create(Customers obj)
    {

    }

    public Customers Read(int customerID)
    {

        return null;
    }

    public void Update()
    {

    }

    public void Delete(int customerID)
    {

    }
}