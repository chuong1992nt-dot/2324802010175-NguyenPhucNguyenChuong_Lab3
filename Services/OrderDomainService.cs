using ECommerce.Domain.Entities;

namespace ECommerce.Domain.Services
{
    public class OrderDomainService
    {

        public bool CanPlaceOrder(Customer? customer, List<OrderItem> items)
        {
            if (customer == null) return false;
            if (items == null || items.Count == 0) return false;

            return true;
        }
    }
}