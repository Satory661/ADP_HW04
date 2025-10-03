namespace ADP_HW04;

internal class Program
{
    public static void Main(string[] args)
    {
        VehicleFactory? vehicleFactory = VehicleChoise.Choise();
        IVehicle? vehicle = vehicleFactory?.CreateVehicle();
        vehicle.Drive();
        vehicle.Refuel();
    }
    
}