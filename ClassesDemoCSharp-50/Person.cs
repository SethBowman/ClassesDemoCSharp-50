namespace ClassesDemoCSharp_50;

public class Person
{
    //Fields - a variable inside of a class (camel case)
    public double wallet;
    public string clothes;
    
    //Properties - things that define the class (pascal case)
    public string Name { get; set; }
    public int Age { get; set; }
    
    //Methods (non static for now)
    public void Greet()
    {
        Console.WriteLine($"Hello, my name is {Name}!");
    }
    
    //Constructors
    
    //Default Constructor
    public Person()
    {
        
    }
    
    //Custom constructor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}