namespace JWTApp.Models.Data
{
    public interface IOrder
    {
        IEnumerable<Order> GetAll();

        Order Get(int id);

        Order Delete(int id);

        void Update(Order order);

        void Create(Order order);

        bool SaveChanges();
      
    }
}
