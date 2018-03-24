using System;
class DemoWorking
{
    static void Main()
    {
        Employee bob = new Employee("Bob");
        Dog spot = new Dog("Spot");
        Cat puff = new Cat("Puff");
        Console.WriteLine(bob.Name + " says " + bob.Work());
        Console.WriteLine(spot.Name + " says " + spot.Work());
        Console.WriteLine(puff.Name + " says " + puff.Work());
        Console.WriteLine("\nPolymorphism");
        IWorkable iwork;
        iwork = bob;
        Console.WriteLine(iwork.Work());
        iwork = spot;
        Console.WriteLine(iwork.Work());
        iwork = puff;
        Console.WriteLine(iwork.Work());
    }
}
public interface IWorkable
{
    string Work();
}
public interface IWorkable2
{
    string Work2();
}
class Employee : IWorkable, IWorkable2
{
    public Employee(string name)
    {
        Name = name;
    }
    public string Name { get; set; }
    public string Work()
    {
        return "I do my job";
    }
    public string Work2()
    {
        return "I do my job";
    }
}
abstract class Animal : IWorkable
{
    public Animal(string name)
    {
        Name = name;
    }
    public string Name { get; set; }
    public abstract string Work();
}
class Dog : Animal
{
    public Dog(string name) : base(name)
    {
    }
    public override string Work()
    {
        return "I watch the house";
    }
}
class Cat : Animal
{
    public Cat(string name) : base(name)
    {
    }
    public override string Work()
    {
        return "I catch mice";
    }
}
