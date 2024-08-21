using ClassesDemoCSharp_50;

var csharp50 = new Classroom();

var seth = new Person();
//Dot notation
seth.Name = "Seth";
seth.Age = 30;
seth.clothes = "t shirt and slacks";
seth.wallet = 500.00;

csharp50.CodingClass.Add(seth);

//Object initializer syntax
var cruz = new Person()
{
    Name = "Cruz",
    Age = 32,
    clothes = "suit",
    wallet = 1000.00
};

csharp50.CodingClass.Add(cruz);

//Using a custom constructor
var bob = new Person("Bob", 28);

csharp50.CodingClass.Add(bob);

csharp50.GreetEveryone();


