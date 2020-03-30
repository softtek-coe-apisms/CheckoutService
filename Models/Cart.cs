using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace checkoutservice.Models
{
    public class Cart
    {
        public Cart() { }

        //public Cart(List<Items> lista)
        //{
        //    Productos = lista;
        //}
        public string idClient { get; set; }
        public List<Items> items { get; set; }
    }
}
