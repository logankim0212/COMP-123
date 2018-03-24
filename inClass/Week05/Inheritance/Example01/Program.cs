using System;
class DemoAnimals2
{
    static void Main()
    {
        Dog spot = new Dog("Spot");
        Cat puff = new Cat("Puff");
        DisplayAnimal(spot);
        DisplayAnimal(puff);
    }
    public static void DisplayAnimal(Animal creature)
    {
        Console.WriteLine(creature.Name + " says " + creature.Speak());
    }
}
class Animal
{
    private string name;
    public Animal(string name)
    {
        this.name = name;
    }

    public string Name
    {
        get
        {
            return name;
        }
    }
    public abstract string Speak();
}
class Dog : Animal
{
    public Dog(string name) : base(name)
    {
    }
    public override string Speak()
    {
        return "woof";
    }
}
class Cat : Animal
{
    public Cat(string name) : base(name)
    {
    }
    public override string Speak()
    {
        return "meow";
    }
}
