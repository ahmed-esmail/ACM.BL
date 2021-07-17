using System;

namespace ACM.BL
{
    public class Order
    {
        public Order()
        {
            
        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public int OrderId { get; set; }
        public DateTimeOffset? OrderData { get; set; }

        public Order Retrieve(int orderId)
        {
            return new Order();
        }
        
        public bool Validate()
        {
            return !(OrderData == null);
        }
        
        public bool Save()
        {
            return true;
        }
    }
}