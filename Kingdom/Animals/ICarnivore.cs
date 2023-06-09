
public interface ICarnivore : IAnimal
{
    public Diet Diet { get; set;}
}

public enum Diet
{
    Vegetarian,
    NonVegetarian,
    Both
}