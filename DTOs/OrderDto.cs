namespace ECommerce.Application.DTOs
{
    // DTO chính cho Đơn hàng
    public class OrderDto
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }

        public List<OrderItemDetailDto> Items { get; set; } = new List<OrderItemDetailDto>();
    }

    public class OrderItemDetailDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}