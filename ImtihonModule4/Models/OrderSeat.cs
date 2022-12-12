
namespace ImtihonModule4.Models
{
    public class OrderSeat
    {
        public OrderSeat(int orderApp_Id, int seat_Id, int orderUserId)
        {
            this.orderApp_Id = orderApp_Id;
            Seat_Id = seat_Id;
            this.orderUserId = orderUserId;
        }

        public OrderSeat(int id, int orderApp_Id, int seat_Id, int orderUserId, bool status)
        {
            Id = id;
            this.orderApp_Id = orderApp_Id;
            Seat_Id = seat_Id;
            this.orderUserId = orderUserId;
            this.status = status;
        }

        public int Id { get; set; }
        public int orderApp_Id { get; set; }
        public int Seat_Id { get;set; }
        public int orderUserId { get; set; }
        public bool status { get; set; }

    }
}
