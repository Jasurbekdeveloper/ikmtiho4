namespace ImtihonModule4.Models
{
    public class OrderAplication
    {
        public OrderAplication(int companyId, int eventHall_Id, DateTime start_at, DateTime end_at)
        {
            this.companyId = companyId;
            this.eventHall_Id = eventHall_Id;
            this.start_at = start_at;
            this.end_at = end_at;
        }

        public OrderAplication(int id, int companyId, int eventHall_Id, DateTime start_at, DateTime end_at, bool status)
        {
            Id = id;
            this.companyId = companyId;
            this.eventHall_Id = eventHall_Id;
            this.start_at = start_at;
            this.end_at = end_at;
            this.status = status;
        }

        public int Id { get; set; }
        public int companyId { get; set; }
        public int eventHall_Id { get; set; }
        public DateTime start_at { get; set; }
        public DateTime end_at { get; set;}
        public bool status { get; set; }


    }
}
