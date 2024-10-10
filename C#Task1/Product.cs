using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Task1;
internal class Product
{
    public string Name { get; set; }
    private decimal price;
    public decimal Price
    {
        get
        {
            return price;
        }
        set
        {
            if(value > 0)
            {
                price = value;
            }
        }
    }
    private int stockQuantity;
    public int StockQuantity
    {
        get
        {
            return stockQuantity;
        }
        set
        {
            if(value > 0)
            {
                stockQuantity = value;
            }
        }
    }
    public bool IsAvailable
    {
        get
        {
            return (StockQuantity > 0);
        }
    }


    public Product(string _name , decimal _price , int _stockQuantity)
    {
        Name = _name;
        Price = _price;
        StockQuantity = _stockQuantity;
    }

    public void UpdateStock(int quantityChange)
    {
        if(StockQuantity + quantityChange > 0)
        {
            StockQuantity += quantityChange;
            Console.WriteLine($"Changed Done , Quantity = {StockQuantity}");
        }
        else
        {
            Console.WriteLine("Qunatity Not Enough");
        }
    }

}
