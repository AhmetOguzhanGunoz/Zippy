using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Products
/// </summary>
public class Products
{    
    /* Fields*/

    private int _ProductID;
    private int _SKU;
    private long _IDSKU;
    private int _VendorProductID;
    private string _ProductName;
    private string _ProductDescription;
    private int _SupplierID;
    private int _CategoryID;
    private int _QuantityPerUnit;
    private double _UnitPrice;
    private string _MSRP;
    private string _AvailableSize;
    private string _AvailableColors;
    private string _Size;
    private string _Color;
    private float _Discount;
    private double _UnitWeight;
    private long _UnitsInStock;
    private long _UnitsInOrder;
    private string _ReorderLevel;
    private bool _ProductAvailable;
    private bool _DiscountAvailable;
    private string _CurrentOrder;
    private byte[] _Picture;
    private string _Ranking;
    private string _Note;
    private string _PromoCode;

    /*properties*/

    public int ProductID
    {
        get { return _ProductID; }
        set { _ProductID = value; }
    }


    public int SKU
    {
        get { return _SKU; }
        set { _SKU = value; }
    }


    public long IDSKU
    {
        get { return _IDSKU; }
        set { _IDSKU = value; }
    }


    public int VendorProductID
    {
        get { return _VendorProductID; }
        set { _VendorProductID = value; }
    }


    public string ProductName
    {
        get { return _ProductName; }
        set { _ProductName = value; }
    }


    public string ProductDescription
    {
        get { return _ProductDescription; }
        set { _ProductDescription = value; }
    }


    public int SupplierID
    {
        get { return _SupplierID; }
        set { _SupplierID = value; }
    }


    public int CategoryID
    {
        get { return _CategoryID; }
        set { _CategoryID = value; }
    }


    public int QuantityPerUnit
    {
        get { return _QuantityPerUnit; }
        set { _QuantityPerUnit = value; }
    }


    public double UnitPrice
    {
        get { return _UnitPrice; }
        set { _UnitPrice = value; }
    }

    public string MSRP
    {
        get { return _MSRP; }
        set { _MSRP = value; }
    }


    public string AvailableSize
    {
        get { return _AvailableSize; }
        set { _AvailableSize = value; }
    }


    public string AvailableColors
    {
        get { return _AvailableColors; }
        set { _AvailableColors = value; }
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


    public float Discount
    {
        get { return _Discount; }
        set { _Discount = value; }
    }

    public double UnitWeight
    {
        get { return _UnitWeight; }
        set { _UnitWeight = value; }
    }


    public long UnitsInStock
    {
        get { return _UnitsInStock; }
        set { _UnitsInStock = value; }
    }


    public long UnitsInOrder
    {
        get { return _UnitsInOrder; }
        set { _UnitsInOrder = value; }
    }


    public string ReorderLevel
    {
        get { return _ReorderLevel; }
        set { _ReorderLevel = value; }
    }


    public bool ProductAvailable
    {
        get { return _ProductAvailable; }
        set { _ProductAvailable = value; }
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


    public byte[] Picture
    {
        get { return _Picture; }
        set { _Picture = value; }
    }


    public string Ranking
    {
        get { return _Ranking; }
        set { _Ranking = value; }
    }

    public string Note
    {
        get { return _Note; }
        set { _Note = value; }
    }

    public string PromoCode
    {
        get { return _PromoCode; }
        set { _PromoCode = value; }
    }
    /*constructor*/

	public Products()
	{
        ProductID = 0;
        SKU = 0;
        IDSKU = 0;
        VendorProductID = 0;
        ProductName= "unknown";
        ProductDescription = "unknown";
        SupplierID = 0;
        CategoryID = 0;
        QuantityPerUnit = 0;
        UnitPrice = 0;
        MSRP = "unknown";
        AvailableSize = "unknown";
        AvailableColors = "unknown";
        Size = "unknown";
        Color = "unknown";
        Discount = 0;
        UnitWeight = 0;
        UnitsInStock = 0;
        UnitsInOrder = 0;
        ReorderLevel = "unknown";
        ProductAvailable = false;
        DiscountAvailable = false;
        CurrentOrder = "unknown";
        Picture = null;
        Ranking = "unknown";
        Note = "unknown";
        PromoCode = "unknown";
	}

    //Methods

    public void Create(Products obj)
    {

    }

    public Products Read(int productID)
    {

        return null;
    }

    public void Update()
    {

    }

    public void Delete(int productID)
    {

    }
}