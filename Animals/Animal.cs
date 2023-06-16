
public class Animal : IAnimal{

    public int EyesCount { get; set;}
    public int EarsCount { get; set;}
    public int NoseCount { get; set;}
    public int MouthCount { get; set;}
    public int LegsCount { get; set;}
    public bool Tail { get; set;}

    //lets set defaults as to what most animals have
    public Animal(){
        this.EyesCount = 2;
        this.EarsCount = 2;
        this.NoseCount = 1;
        this.MouthCount = 1;
        this.LegsCount = 4;
        this.Tail = true;
    }

}