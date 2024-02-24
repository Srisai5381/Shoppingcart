using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartModels
{
    internal class Shoppingcart
    {
        public int Id { get; set; }
        public string User { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
