using InventoryLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryLibrary
{
    public class StockKeeper
    {

        public static List<ProductModel> products = new List<ProductModel>();

        public static void UpdateStock()
        {
            string result = "";
            do
            {
                Console.Write("Do You Want To Add Item To Stock(yes/no) : ");
                result = Console.ReadLine();
                if (result.ToLower() == "yes")
                {
                    ProductModel product = new ProductModel();
                    Console.Write("Enter Product Number : ");
                    string numberText = Console.ReadLine();
                    bool isValidNumber = int.TryParse(numberText, out int number);
                    while (isValidNumber == false)
                    {
                        Console.WriteLine("Wrong Input,Please Try Again");
                        Console.Write("Enter Product Number : ");
                        numberText = Console.ReadLine();
                        isValidNumber = int.TryParse(numberText, out number);
                    }
                    product.ProductNumber = number;

                    Console.Write("Enter Product Name : ");
                    string name = Console.ReadLine();
                    product.ProductName = name;

                    Console.Write("Enter Quantity In Stock : ");
                    string quantityInStockText = Console.ReadLine();
                    bool isValidStockNumber = int.TryParse(quantityInStockText, out int stockNumber);
                    while (isValidStockNumber == false)
                    {
                        Console.WriteLine("Wrong Input,Please Try Again");
                        Console.Write("Enter Quantity In Stock : ");
                        numberText = Console.ReadLine();
                        isValidStockNumber = int.TryParse(numberText, out stockNumber);
                    }
                    product.QuantityInStock = stockNumber;

                    Console.Write("Enter The Price In One Peice : ");
                    string priceText = Console.ReadLine();
                    bool isValidPrice = double.TryParse(priceText, out double price);
                    while (isValidPrice == false)
                    {
                        Console.WriteLine("Wrong Input,Please Try Again");
                        Console.Write("Enter the Price In One Peice : ");
                        priceText = Console.ReadLine();
                        isValidPrice = double.TryParse(priceText, out price);
                    }
                    product.Price = price;

                    products.Add(product);

                    Console.WriteLine();

                }


            } while (result.ToLower() == "yes");

            Console.Clear();
            
        }

    }
}
