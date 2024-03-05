public class Vehicle
{
    public string Type { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }

    public string Move()
    {
        return $"{Year} {Brand} {Model} is moving on the road";
    }

    public string GetDetails()
    {
        return $"{Type}: {Year} {Brand} {Model}, Color: {Color}";
    }
}
