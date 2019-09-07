using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingV2
{
   public class CartItem
    {
        [DisplayName("itemName")]
        public string itemName { get; set;}
        [DisplayName("quantity")]
        public int quantity { get; set; }
        [DisplayName("unitPrice")]
        public double unitPrice { get; set; }
        [DisplayName("totalPrice")]

        public double totalPrice { get; set;}



    }
}
