namespace RocketElevators.Models
{
    public class Elevator
    {
        public long Id { get; set; }
        public int? Serial_Number { get; set; }
        public string? Model { get; set; }
        public DateTime? Date_Of_Commissioning { get; set; }
        public DateTime? Date_Of_last_Inspection { get; set; }
        public string? Certificate_Of_Inspection { get; set; }
        public string? Status { get; set; }
        public long column_id { get; set; }
        public Column? Columns { get; set; }
    }
}