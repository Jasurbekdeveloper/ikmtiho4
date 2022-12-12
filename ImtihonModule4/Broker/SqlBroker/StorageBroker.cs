
using ImtihonModule4.Models;

namespace ImtihonModule4.Broker.SqlBroker
{
    public class StorageBroker : IStorageBroker
    {
        private string connectionString = @"Server=DESKTOP-OS12T5I; user id=sa; password=4422; Database=EventMenagement;";
        public Task<EventHall> DeleteEventHallAsync(int id)
        {
            
        }

        public Task<User> GetAllUserAsync()
        {
            throw new NotImplementedException();
        }

        public Task<EventHall> InsertEventHallAsync(EventHall post)
        {
            throw new NotImplementedException();
        }

        public Task<OrderAplication> InsertOrderAppAsync(OrderAplication app)
        {
            throw new NotImplementedException();
        }

        public Task<OrderSeat> InsertOrderSeatAsync(OrderSeat seat)
        {
            throw new NotImplementedException();
        }

        public Task<User> InsertUserAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task<OrderAplication> SetAppStatusAsync(bool status, int appId)
        {
            throw new NotImplementedException();
        }
    }
}
