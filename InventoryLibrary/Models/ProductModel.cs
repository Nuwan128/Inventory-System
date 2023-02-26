using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryLibrary.Models
{
    public class ProductModel
    {
        public int ProductNumber { get; set; }
        public string ProductName { get; set; }

        public double Price { get; set; }

        public int QuantityInStock { get; set; }


    }
}
