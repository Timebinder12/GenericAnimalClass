using System;


public class Animal < T > //generic animal class
{
    public T data;
    
    public Animal( T data ) //constructor
    {
        this.data = data;
    }
    public T getAnimal()//display method
    {
        return this.data;
    }

}
class Program
{
    static void Main(string[] args)
    {
        //Creating animal objects
        Animal<string> animalName = new Animal<string>("Baboon");
        Animal<string> animalHabitat = new Animal<string>("These monkeys prefer semi-arid habitats, like savannas and bushlands, but some live in tropical forests and mountains");
        Animal<bool> endangered = new Animal<bool>(false);
        Animal<bool> extinct = new Animal<bool>(false);
        Animal<int> averageLifespan = new Animal<int>(40);

        //Displaying animal information
        Console.WriteLine($"Animal name: {animalName.getAnimal()}"); 
        Console.WriteLine($"Animal habitat: {animalHabitat.getAnimal()}");
        Console.WriteLine($"Animal endangered: {endangered.getAnimal()}");
        Console.WriteLine($"Animal extinct: {extinct.getAnimal()}");
        Console.WriteLine($"Animal average lifespan: {averageLifespan.getAnimal()}");


    }
}
