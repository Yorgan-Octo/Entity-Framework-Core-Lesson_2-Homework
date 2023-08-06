using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Product
    {

        [Column("ProductId")]
        public int Id { get; set; }
        public int ProductAlterId { get; set; }

        [MaxLength(15)]
        [Required]
        public string Name { get; set; }
        public double Cost { get; set; }

        [MaxLength(50)]
        public string Description { get; set; }
        public int Quantity { get; set; }

        [Column(TypeName = "Date")]
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
