
public interface IWarmBlooded : IAnimal
{
    public Blood Blooded { get; set;}
}

public enum Blood
{
    Warm,
    Cold
}