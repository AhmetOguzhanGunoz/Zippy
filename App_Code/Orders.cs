using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Orders
/// </summary>
public class Orders
{

    /* Fields*/

    private int _OrderID;
    private int _CustomerID;
    private int _OrderNumber;
    private int _PaymentID;
    private DateTime _OrderDate;
    private DateTime _ShipDate;
    private DateTime _RequiredDate;
    private int _ShipperID;
    private string _Freight;
    private float _SalesTax;
    private DateTime _TimeStamp;
    private string _TransactionStatus;
    private string _ErrorLoc;
    private string _ErrorMsg;
    private bool _Fulfilled;
    private bool _Deleted;
    private bool _Paid;
    private DateTime _PaymentDate;
    
    /*properties*/

    public int OrderID
    {
        get { return _OrderID; }
        set { _OrderID = value; }
    }

    public int CustomerID
    {
        get { return _CustomerID; }
        set { _CustomerID = value; }
    }

    public int OrderNumber
    {
        get { return _OrderNumber; }
        set { _OrderNumber = value; }
    }

    public int PaymentID
    {
        get { return _PaymentID; }
        set { _PaymentID = value; }
    }

    public DateTime OrderDate
    {
        get { return _OrderDate; }
        set { _OrderDate = value; }
    }

    public DateTime ShipDate
    {
        get { return _ShipDate; }
        set { _ShipDate = value; }
    }

    public DateTime RequiredDate
    {
        get { return _RequiredDate; }
        set { _RequiredDate = value; }
    }

    public int ShipperID
    {
        get { return _ShipperID; }
        set { _ShipperID = value; }
    }

    public string Freight
    {
        get { return _Freight; }
        set { _Freight = value; }
    }

    public float SalesTax
    {
        get { return _SalesTax; }
        set { _SalesTax = value; }
    }

    public DateTime TimeStamp
    {
        get { return _TimeStamp; }
        set { _TimeStamp = value; }
    }

    public string TransactionStatus
    {
        get { return _TransactionStatus; }
        set { _TransactionStatus = value; }
    }

    public string ErrorLoc
    {
        get { return _ErrorLoc; }
        set { _ErrorLoc = value; }
    }

    public string ErrorMsg
    {
        get { return _ErrorMsg; }
        set { _ErrorMsg = value; }
    }

    public bool Fulfilled
    {
        get { return _Fulfilled; }
        set { _Fulfilled = value; }
    }

    public bool Deleted
    {
        get { return _Deleted; }
        set { _Deleted = value; }
    }

    public bool Paid
    {
        get { return _Paid; }
        set { _Paid = value; }
    }

    public DateTime PaymentDate
    {
        get { return _PaymentDate; }
        set { _PaymentDate = value; }
    }

    /*constructor*/
	public Orders()
	{
        OrderID = 0;
        CustomerID = 0;
        OrderNumber = 0;
        PaymentID = 0;
        OrderDate = new DateTime(0,0,0);
        ShipDate = new DateTime(0,0,0);
        RequiredDate = new DateTime(0,0,0);
        ShipperID = 0;
        Freight = "unknown";
        SalesTax = 0;
        TimeStamp = new DateTime(0,0,0);
        TransactionStatus = "unknown";
        ErrorLoc = "unknown";
        ErrorMsg = "unknown";
        Fulfilled = false;
        Deleted = false;
        Paid = false;
        PaymentDate = new DateTime(0,0,0);
	}

    //Methods

    public void Create(Orders obj)
    {

    }

    public Orders Read(int orderID)
    {

        return null;
    }

    public void Update()
    {

    }

    public void Delete(int orderID)
    {

    }
}