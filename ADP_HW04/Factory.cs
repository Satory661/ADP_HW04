namespace ADP_HW04;

    public abstract class VehicleFactory
    {
        public abstract IVehicle CreateVehicle();
    }

    // Фабрика автобусов
    public class BusFactory : VehicleFactory
    {
        public override IVehicle CreateVehicle()
        {
            Console.WriteLine("seats: ");
            int seats = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("route: ");
            string route = Console.ReadLine();

            return new Bus(seats, route);
        }
    }

    // Фабрика автомобилей
    public class CarFactory : VehicleFactory
    {
        public override IVehicle CreateVehicle()
        {
            Console.WriteLine("model: ");
            string model = Console.ReadLine();
            Console.WriteLine("brand: ");
            string brand = Console.ReadLine();
            Console.WriteLine("type of fuel: ");
            string typeOfFuel = Console.ReadLine();

            return new Car(model, brand, typeOfFuel);
        }
    }

    // Фабрика мотоциклов
    public class MotorcycleFactory : VehicleFactory
    {
        public override IVehicle CreateVehicle()
        {
            Console.WriteLine("type: ");
            string type = Console.ReadLine();
            Console.WriteLine("engine volume: ");
            double eng = Convert.ToDouble(Console.ReadLine());

            return new Motorcycle(type, eng);
        }
    }

    // Фабрика грузовиков
    public class TruckFactory : VehicleFactory
    {
        public override IVehicle CreateVehicle()
        {
            Console.WriteLine("capacity: ");
            double capacity = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("axles: ");
            int axles = Convert.ToInt32(Console.ReadLine());

            return new Truck(capacity, axles);
        }
    }
// END update