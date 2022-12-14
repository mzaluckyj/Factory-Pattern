namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many tires?");
            int numWheels;
            var input = int.TryParse(Console.ReadLine(), out numWheels);

         var vehicle = VehicleFactory.GetVehicle(numWheels);
            vehicle.Drive();
        }
    }
}
