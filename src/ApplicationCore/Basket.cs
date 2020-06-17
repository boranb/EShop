using System.Collections.Generic;
using ApplicationCore.Entities;

namespace ApplicationCore
{
    public class Basket : BaseEntity
    {
        public string BuyerId { get; set; }
        public List<BasketItem> Items { get; set; } 
    }
}
