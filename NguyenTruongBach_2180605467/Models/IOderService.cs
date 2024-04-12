namespace NguyenTruongBach_2180605467.Models
{
    public interface IOderService
    {
        Task<IEnumerable<Order>> GetAllOrders();
        Task<Order> GetOrderById(int id);
        Task AddOrder(Order order);
        Task UpdateOrder(Order order);
        Task DeleteOrder(int id);
    }
}
