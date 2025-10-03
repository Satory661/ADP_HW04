namespace ADP_HW04;

public class VehicleChoise
{
    public static VehicleFactory? Choise()
    {
        Console.Write("Enter the type of the vehicle (1- Car, 2- Truck, 3- Bus, 4- motorcycle): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                return new CarFactory();
            case 2:
                return new TruckFactory();
            case 3:
                return new BusFactory();
            case 4:
                return new MotorcycleFactory();
            default:
                return null;
        }
    }
}
// END update