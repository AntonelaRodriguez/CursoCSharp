
using System;

Operation mySum = Functions.Sum;
Console.WriteLine(mySum(2,3)); // 5
mySum = Functions.Mul;
Console.WriteLine(mySum(2, 3)); // 6

Show show = Functions.ConsoleShow;
show("Hola mundo");

Show cw = Console.WriteLine;
cw += Functions.ConsoleShow;
cw("hola mundo");

Functions.Some("Juan", "Guevara", cw);

#region Action
//es una funcion que ejecuta pero no regresa nada
Action<string> showMessage = Console.WriteLine;
//Functions.SomeAction("Hector", "De León", showMessage);
string hi = "Hola";
Action<string, string> showMessage1 = (a, b) => { Console.WriteLine($"{hi} {a} {b}"); };
showMessage1("Hector", "De Leon");
Action<string, string, string> showMessage2 = (a, b, c) => Console.WriteLine($"{a} {b} {c}");
showMessage2("Hector", "De Leon", "dev");
Functions.SomeAction("Hector", "De León", (a) =>
{
    Console.WriteLine("soy una expresion lambda" + a);
});
#endregion

#region Func
Func<int> numberRandom = () => new Random().Next(0, 100);
Console.WriteLine($"{numberRandom()}");
Func<int, int> numberRandomLimit = (limit) => new Random().Next(0, limit);
Console.WriteLine($"{numberRandomLimit(1000)}");
#endregion

#region Predicate
Predicate<string> hasSpaceOrA = (word) => word.Contains(" ") || word.ToUpper().Contains("A");
Console.WriteLine(hasSpaceOrA("beear"));
Console.WriteLine(hasSpaceOrA("pa ti to"));

var words = new List<string>()
{
    "beer",
    "patito",
    "sandia",
    "hola mundo",
    "c#"
};
var wordsNew = words.FindAll(w => !hasSpaceOrA(w));
foreach (var w in wordsNew) Console.WriteLine(w);
#endregion

#region Delegados
delegate int Operation(int a, int b); // el delegato va a ser la estructura de la funcion que retorne un entero y reciba un entero
public delegate void Show(string message); // un delegado que va a ser la estructura de la funcion que no retorne nada y reciba un string
public delegate void Show1(string message, string message1);
public delegate void Show2(string message, string message1, string message2);
#endregion

public class Functions
{
    public static int Sum(int x, int y) => x + y;
    public static int Mul(int num1, int num2) => num1 * num2;

    public static void ConsoleShow(string n) => Console.WriteLine(n.ToUpper());

    public static void Some(string name, string lastName, Show fn)
    {
        Console.WriteLine("Hago algo al inicio");
        fn($"Hola {name} {lastName}");
        Console.WriteLine("Hago algo al final");

    }
    public static void SomeAction(string name, string lastName, Action<string> fn)
    {
        Console.WriteLine("Hago algo al inicio");
        fn($"Hola {name} {lastName}");
        Console.WriteLine("Hago algo al final");

    }
}