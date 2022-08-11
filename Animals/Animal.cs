
public class Animal : IAnimal{

    public int eyesCount { get; set;}
    public int legsCount { get; set;}
    public bool hasTail { get; set;}

    //lets set defaults as to what most animals have
    public Animal(){
        this.eyesCount = 2;
        this.legsCount = 4;
        this.hasTail = true;
    }

}