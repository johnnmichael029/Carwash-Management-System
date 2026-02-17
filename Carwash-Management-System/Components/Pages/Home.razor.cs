using Carwash_Management_System.Models;

namespace Carwash_Management_System.Components.Pages
{
    public partial class Home
    {
       
        private readonly List<CarService> PriceList =
    [
        new CarService { VehicleType = "Hatchback", Wash = 140, Wax = 400, Engine = 450 },
        new CarService { VehicleType = "Sedan", Wash = 150, Wax = 450, Engine = 500 },
        new CarService { VehicleType = "Compact / Changan", Wash = 180, Wax = 500, Engine = 550 },
        new CarService { VehicleType = "SUV", Wash = 250, Wax = 550, Engine = 600 },
        new CarService { VehicleType = "Pick Up / Travis", Wash = 280, Wax = 600, Engine = 650 },
        new CarService { VehicleType = "Van / L300", Wash = 280, Wax = 700, Engine = 750 },
        new CarService { VehicleType = "Jeep", Wash = 300, Wax = 750, Engine = 800 },
        new CarService { VehicleType = "Big Bike", Wash = 160, Wax = 250, Engine = 0 },
        new CarService { VehicleType = "Motorcycle (150cc)", Wash = 140, Wax = 200, Engine = 0 },
        new CarService { VehicleType = "Motorcycle (125cc)", Wash = 130, Wax = 150, Engine = 0 },
        new CarService { VehicleType = "Motorcycle (110cc)", Wash = 120, Wax = 100, Engine = 0 },
        new CarService { VehicleType = "Tricycle", Wash = 150, Wax = 0, Engine = 0 }
    ];

    }
}
