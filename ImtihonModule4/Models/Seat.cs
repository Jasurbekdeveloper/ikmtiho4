namespace ImtihonModule4.Models
{
    public class Seat
    {
        public Seat(int seat_num, int event_hall_id)
        {
            this.seat_num = seat_num;
            this.event_hall_id = event_hall_id;
        }

        public Seat(int id, int seat_num, int event_hall_id, bool status)
        {
            Id = id;
            this.seat_num = seat_num;
            this.event_hall_id = event_hall_id;
            this.status = status;
        }

        public int Id { get; set; }
        public int seat_num { get; set; }
        public int event_hall_id { get; set; }
        public bool status { get; set; }
    }
}
