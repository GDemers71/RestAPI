    namespace RocketElevators.Models
{
        public class Customer
    {
        public long Id { get; set; }
        public string? Company_Name { get; set; }
        public string? Company_Headquarters_Adress { get; set; }
        public string? Full_Name_Of_The_Company_Contact { get; set; }
        public string? Company_Contact_Phone { get; set; }
        public string? Email_Of_The_Company_Contact { get; set; }
        public string? Company_Description { get; set; }
        public string? Full_Name_Of_Service_Technical_Authority { get; set; }
        public string? Technical_Manager_Email_For_Service { get; set; }
        public List<Building>? Buildings { get; set; }
    }
}