using ImtihonModule4.Models;

namespace ImtihonModule4.Broker.SqlBroker
{
    public interface IStorageBroker
    {
        public Task<User> GetAllUserAsync();
        public Task<User> InsertUserAsync(User user);
        public Task<EventHall> InsertEventHallAsync(EventHall post);
        public Task<OrderAplication> SetAppStatusAsync(bool status, int appId);
        public Task<OrderAplication> InsertOrderAppAsync(OrderAplication app);
        public Task<OrderSeat> InsertOrderSeatAsync(OrderSeat seat);

        public Task<bool> DeleteEventHallAsync(int id);
    }
}
