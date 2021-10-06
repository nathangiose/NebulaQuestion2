using System;
public class Animal
{
    public void eat() { Console.WriteLine("Yummy"); }

}


public class Horse : Animal
{
    public void MakeNoise() { Console.WriteLine("Neigh"); }
}



public class Sheep : Horse
{
    public void Filled() { Console.WriteLine("Baaah"); }
}
class TestInheritance2
{
    public static void Main(string[] args)
    {
        Sheep d1 = new Sheep();
        d1.eat();
        d1.MakeNoise();
        d1.Filled();
    }
}