using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for OrderDetails
/// </summary>
public class OrderDetails
{

    /* Fields*/
    private int _OrderDetailID;    
    private int _ProductID;
    private int _OrderNumber;
    private float _Price;
    private int _Quantity;
    private float _Discount;
    private float _Total;
    private long _IDSKU;
    private string _Size;
    private string _Color;
    private bool _Fulfilled;
    private DateTime _ShipDate;
    private int _OrderID;
    private DateTime _BillDate;


    /*properties*/

    public int OrderID
    {
        get { return _OrderID; }
        set { _OrderID = value; }
    }

    public int ProductID
    {
        get { return _ProductID; }
        set { _ProductID = value; }
    }

    public int OrderNumber
    {
        get { return _OrderNumber; }
        set { _OrderNumber = value; }
    }

    public float Price
    {
        get { return _Price; }
        set { _Price = value; }
    }

    public int Quantity
    {
        get { return _Quantity; }
        set { _Quantity = value; }
    }

    public float Discount
    {
        get { return _Discount; }
        set { _Discount = value; }
    }

    public float Total
    {
        get { return _Total; }
        set { _Total = value; }
    }

    public long IDSKU
    {
        get { return _IDSKU; }
        set { _IDSKU = value; }
    }

    public string Size
    {
        get { return _Size; }
        set { _Size = value; }
    }

    public string Color
    {
        get { return _Color; }
        set { _Color = value; }
    }

    public bool Fulfilled
    {
        get { return _Fulfilled; }
        set { _Fulfilled = value; }
    }

    public DateTime ShipDate
    {
        get { return _ShipDate; }
        set { _ShipDate = value; }
    }

    public int OrderDetailID
    {
        get { return _OrderDetailID; }
        set { _OrderDetailID = value; }
    }

    public DateTime BillDate
    {
        get { return _BillDate; }
        set { _BillDate = value; }
    }

    /*constructor*/

	public OrderDetails()
	{
        OrderDetailID = 0; 
        ProductID = 0;
        OrderNumber = 0;
        Price = 0;
        Quantity = 0;
        Discount = 0;
        Total = 0;
        IDSKU = 0;
        Size = "unknown";
        Color = "unknown";
        Fulfilled = false;
        ShipDate = new DateTime(0,0,0);
        OrderID = 0;
        BillDate = new DateTime(0, 0, 0);
	}

    //Methods

    public void Create(OrderDetails obj)
    {

    }

    public OrderDetails Read(int orderDetailID)
    {

        return null;
    }

    public void Update()
    {

    }

    public void Delete(int orderDetailID)
    {

    }
}