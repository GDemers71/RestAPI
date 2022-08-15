namespace RocketElevators.Models
{
    public class Battery
    {
        public long Id { get; set; }
        public string? Status { get; set; }
        public string? Type { get; set; }
        public DateTime? Date_Of_Commissioning { get; set; }
        public DateTime? Date_Of_last_Inspection { get; set; }
        public string? Information { get; set; }
        public long building_id { get; set; }
        public Building ?Building { get; set; }
        public List<Column>? Columns { get; set; }

        
    }
}