using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.Entities.Models
{
    public class Card
    {
        public int CardID { get; set; }
        public List<CartItem> CardItems { get; set; } = new List<CartItem>();

        public void AddItem(CartItem item)
        {
            var p = CardItems.FirstOrDefault(c => c.ProductID == item.ProductID);

            if (p != null)
            {
                p.Quantity += item.Quantity;
            }
            else
            {
                CardItems.Add(item);
            }
        }

        public void DeleteItem(Guid cardItemID)
        {
            CartItem? c = CardItems.FirstOrDefault(item => item.CardItemID == cardItemID);

            if (c != null)
            {
                c.Quantity -= 1;
            }

            if (c.Quantity == 0)
            {
                CardItems.Remove(c);
            }
        }
    }
}
