using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Promotion
/// </summary>
public class Promotion
{

	public Promotion()
	{

	}

    private string GeneratePromoCode()
    {
        Guid obj = Guid.NewGuid();

        return (obj.ToString("N").Substring(0, 10));
    }

    public Products GenerateDiscount()
    {
        Random Rate = new Random();
        int DC_Rate = Rate.Next(10, 26);

        Products product = new Products();

        product.DiscountAvailable = true;
        product.Discount = DC_Rate;
        product.PromoCode = GeneratePromoCode();

        return product;
    }


}