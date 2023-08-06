using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public DateTime WentOnSale { get; set; }

        public Product(string name, double cost, string description, int quantity, DateTime wentOnSale)
        {
            Name = name;
            Cost = cost;
            Description = description;
            Quantity = quantity;
            WentOnSale = wentOnSale;
        }
    }

}

