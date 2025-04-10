namespace CarsTestProject.Models
{    
    public class Car
    {
        public string CarBrand { get; set; }
        public string CarType { get; set; }
        public string TransmissionType { get; set; } //enum
        public decimal Price { get; set; }

        public List<Car> GetCars()
        {
            var car1 = new Car
            {
                CarBrand = "Ford",
                CarType = "Fiesta",
                TransmissionType = "Manual",
                Price = 125000000
            };

            var car2 = new Car
            {
                CarBrand = "Ford",
                CarType = "Fiesta",
                TransmissionType = "Manual",
                Price = 135000000
            };

            var car3 = new Car
            {
                CarBrand = "Ford",
                CarType = "Fiesta",
                TransmissionType = "Automatic",
                Price = 140000000
            };

            var car4 = new Car
            {
                CarBrand = "Ford",
                CarType = "Fiesta",
                TransmissionType = "Manual",
                Price = 155000000
            };

            var car5 = new Car
            {
                CarBrand = "HONDA",
                CarType = "BRV",
                TransmissionType = "Manual",
                Price = 160000000
            };

            var car6 = new Car
            {
                CarBrand = "HONDA",
                CarType = "BRV",
                TransmissionType = "Manual",
                Price = 175000000
            };

            var car7 = new Car
            {
                CarBrand = "HONDA",
                CarType = "HRV",
                TransmissionType = "Automatic",
                Price = 185000000
            };

            var car8 = new Car
            {
                CarBrand = "HONDA",
                CarType = "HRV",
                TransmissionType = "Automatic",
                Price = 195000000
            };


            List<Car> cars = new List<Car>();
            cars.Add(car1);
            cars.Add(car2);
            cars.Add(car3);
            cars.Add(car4);
            cars.Add(car5);
            cars.Add(car6);
            cars.Add(car7);
            cars.Add(car8);

            return cars;
        }                
    }
}
