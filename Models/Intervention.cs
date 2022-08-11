namespace RocketElevators.Models
{
    public class Intervention
    {
        public long Id { get; set; }
        public long author { get; set; }
        public long customer_id { get; set; }
        public long building_id { get; set; }
        public long battery_id { get; set; }
        public long? column_id { get; set; }
        public long? elevator_id { get; set; }
        public DateTime? start_date_and_time_of_the_intervention { get; set; }
        public DateTime? end_date_and_time_of_the_intervention { get; set; }
        public string? result { get; set; }
        public string? report { get; set; }
        public string? status { get; set; }
    }
}