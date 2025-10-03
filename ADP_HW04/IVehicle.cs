namespace ADP_HW04;
    public interface IVehicle
    {
        void Drive();
        void Refuel();
    }

    // Автобус
    public class Bus : IVehicle
    {
        private int _seats;
        private string _route;

        public Bus(int seats, string route)
        {
            _seats = seats;
            _route = route;
        }

        public void Drive()
        {
            Console.WriteLine("Bus Drive");
        }

        public void Refuel()
        {
            Console.WriteLine("Bus Refuel");
        }
    }

    // Автомобиль
    public class Car : IVehicle
    {
        private string _model;
        private string _brand;
        private string _typeOfFuel;

        public Car(string model, string brand, string typeOfFuel)
        {
            _model = model;
            _brand = brand;
            _typeOfFuel = typeOfFuel;
        }

        public void Drive()
        {
            Console.WriteLine("Car driven");
        }

        public void Refuel()
        {
            Console.WriteLine("Car refuel");
        }
    }

    // Мотоцикл
    public class Motorcycle : IVehicle
    {
        private string _type;
        private double _engineVolume;

        public Motorcycle(string type, double engineVolume)
        {
            _type = type;
            _engineVolume = engineVolume;
        }

        public void Drive()
        {
            Console.WriteLine("Motorcycle Drive");
        }

        public void Refuel()
        {
            Console.WriteLine("Motorcycle Refuel");
        }
    }

    // Грузовик
    public class Truck : IVehicle
    {
        private double _capacity;
        private int _axles;

        public Truck(double capacity, int axles)
        {
            _capacity = capacity;
            _axles = axles;
        }

        public void Drive()
        {
            Console.WriteLine("Truck Drive");
        }

        public void Refuel()
        {
            Console.WriteLine("Truck Refuel");
        }
    }