using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Category
/// </summary>
public class Category
{
    /* Fields*/

    private int _CategoryID;
    private string _CategoryName;
    private string _Description;
    private byte[] _Picture;
    private bool _Active;

    /*properties*/

    public int CategoryID
    {
        get { return _CategoryID; }
        set { _CategoryID = value; }
    }

    public string CategoryName
    {
        get { return _CategoryName; }
        set { _CategoryName = value; }
    }

    public string Description
    {
        get { return _Description; }
        set { _Description = value; }
    }

    public byte[] Picture
    {
        get { return _Picture; }
        set { _Picture = value; }
    }

    public bool Active
    {
        get { return _Active; }
        set { _Active = value; }
    }

    /*constructor*/
	public Category()
	{
        CategoryID = 0;
        CategoryName = "unknown";
        Description = "unknown";
        Picture = null;
        Active = false;
	}

    //Methods

    public void Create(Category obj)
    {

    }

    public Category Read(int categoryID)
    {

        return null;
    }

    public void Update()
    {

    }

    public void Delete(int categoryID)
    {

    }
}