using System;

using MethodOverloading;

//Add method with ints
Console.WriteLine("Enter two integers: ");
var firstNum = int.Parse(Console.ReadLine());
var secondNum = int.Parse(Console.ReadLine());

Console.WriteLine(Methods.Add(firstNum, secondNum));

//Add method with decimals
Console.WriteLine("Enter two decimals: ");
var firstDec = decimal.Parse(Console.ReadLine());
var secondDec = decimal.Parse(Console.ReadLine());

Console.WriteLine(Methods.Add(firstDec, secondDec));

//Add method with integers
//Denotes if in dollars or not
Console.WriteLine("Now enter two integers: ");
firstNum = int.Parse(Console.ReadLine());
secondNum = int.Parse(Console.ReadLine());

Console.WriteLine("Are these dollars? Y or N:");
var isDollars = Console.ReadLine();
bool USD;
switch ((isDollars.ToLower()))
{
    case "Y":
    case "y":
        USD = true;
        break;
    case "N":
    case "n":
        USD = false;
        break;
    default:
        Console.WriteLine("Error: invalid input");
        return;
}

Console.WriteLine(Methods.Add(firstNum, secondNum, USD));