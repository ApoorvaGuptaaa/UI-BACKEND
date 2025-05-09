using System;

public class House
{
	public string Walls { get; set; }
	public string Roof { get; set; }
	public string Doors { get; set; }

}

public interface IHouseBuilder
{
	void BuildWalls();
	void BuildRoof();
	void BuildDoors();
	House  GetHouse();
}

public class ConcreteHouse : IHouseBuilder {
    public void BuildWalls() => _house.Walls = "Concrete Walls";
    public void BuildRoof() => _house.Roof = "Concrete Roof";
    public void BuildDoors() => _house.Doors = "Wooden Doors";
    public House GetHouse() => _house;
}

public class Director
{
    private IHouseBuilder _builder;

    public Director(IHouseBuilder builder) => _builder = builder;

    public void ConstructHouse()
    {
        _builder.BuildWalls();
        _builder.BuildRoof();
        _builder.BuildDoors();
    }
}

class Builder {
    public static void Main(string[] args) {
        var builder = new ConcreteHouseBuilder();
        var director = new Director(builder);
        director.ConstructHouse();
        House house = builder.GetHouse();
        Console.WriteLine($"House with {house.Walls}, {house.Roof}, and {house.Doors}");
    }
}