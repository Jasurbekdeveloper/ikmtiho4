
using ImtihonModule4.Models;
using System.Data.SqlClient;

namespace ImtihonModule4.Broker.SqlBroker
{
    public class StorageBroker : IStorageBroker
    {
        private string connectionString = @"Server=DESKTOP-OS12T5I; user id=sa; password=4422; Database=EventMenagement;";
        public async Task<bool> DeleteEventHallAsync(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand command = new SqlCommand($"exec [dbo].[DeleteEvetHall] @evetHall_Id", connection);
                command.Parameters.Add(new SqlParameter("@evetHall_Id", id));
                await connection.OpenAsync();

                return true;
            }
            return false;
        }

        public async Task<User> GetAllUserAsync()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                List<User> users = new List<User>();

                SqlCommand command = new SqlCommand($"exec [dbo].[SelectAllUser]", connection);
                
                await connection.OpenAsync();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    users.Add(new User(
                        id: reader.GetInt32(0),
                        username: reader.GetString(1),
                        password: reader.GetInt32(2),
                        phone: reader.GetString(3),
                        role: (Role)reader.GetInt32(4))
                    );
                }
            }
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
