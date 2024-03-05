public class VehicleFactory
{
    private static VehicleFactory _instance;
    private static readonly object _lock = new object();

    private VehicleFactory() { }

    public static VehicleFactory Instance
    {
        get
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new VehicleFactory();
                }
                return _instance;
            }
        }
    }

    public Vehicle CreateVehicle(string type, string brand, string model, int year, string color)
    {
        Vehicle vehicle = new Vehicle
        {
            Type = type,
            Brand = brand,
            Model = model,
            Year = year,
            Color = color
        };
        return vehicle;
    }
}
