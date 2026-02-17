namespace Carwash_Management_System.Models
{
    public class CarService
    {
        public required string VehicleType { get; set; }
        public int Wash { get; set; }
        public int Wax { get; set; }
        public int Engine { get; set; }
    }
}
