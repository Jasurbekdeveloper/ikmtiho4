namespace ImtihonModule4.Models
{
    public class EventHall
    {
        public EventHall(string hallName, int size, decimal price)
        {
            this.hallName = hallName;
            this.size = size;
            this.price = price;
        }

        public EventHall(int _id, string hallName, int size, decimal price)
        {
            id = _id;
            this.hallName = hallName;
            this.size = size;
            this.price = price;
        }

        public int id { get; set; }
        public string hallName { get; set; }
        public int size { get; set; }
        public decimal price { get; set;}
    }
}
