//Titel and colors
Console.Title = "Gurli";
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.BackgroundColor = ConsoleColor.White;


Console.WriteLine("Hello there, what's your name my friend?");

string userName = Console.ReadLine();

Console.WriteLine("Hello there " + userName + ". It's nice to see you here.\nI'm Gurli, your personal AI.");

Console.ReadLine();


Console.WriteLine("How old are you?");

string myAge = Console.ReadLine();

Console.WriteLine("You're " + myAge + "? That's nice :)");

Console.ReadLine();

int height;

Console.WriteLine("Now i want you to put in your height for me in cm: ");
height = Convert.ToInt32(Console.ReadLine());

if (height == 171)
{
    Console.WriteLine("Okay, that's decent height");
}
else if (height >= 171)
{
    Console.WriteLine("Okay, okay. Maybe you should relax a bit with those vegetabel;)");
}
else
{
    Console.WriteLine("HA, maybe you should try and eat more? Or maybe someone in your family took your height? My little friend");
}

int num01;
int num02;
int num03;

Console.WriteLine("Now, let's have some fun:) \nI want you to input a number here: ");

num01 = Convert.ToInt32( Console.ReadLine() );

Console.WriteLine("Now I need you to insert another number :");

num02 = Convert.ToInt32( Console.ReadLine() );

Console.WriteLine("Now I just need you to insert a last number :");

num03 = Convert.ToInt32( Console.ReadLine() );

Console.WriteLine("Cool.");
 
int result = num01 * num02 + num03;
Console.WriteLine("The result by multiplying the first two numbers and adding the last number is " + result);

Console.WriteLine("\nOkay. \nNow will you please insert a number between 1 and 10:");
int num = Convert.ToInt32(Console.ReadLine());

switch (num) 
{
    case 1:
        Console.WriteLine("One");
        break;
    case 2:
        Console.WriteLine("Two");
        break;
    case 3:
        Console.WriteLine("Three");
        break;
    case 4:
        Console.WriteLine("Four");
        break;
    case 5:
        Console.WriteLine("Five");
        break;
    case 6:
        Console.WriteLine("Six");
        break;
    case 7:
        Console.WriteLine("Seven");
        break;
    case 8:
        Console.WriteLine("Eight");
        break;
    case 9:
        Console.WriteLine("Nine");
        break;
    case 10:
        Console.WriteLine("Ten");
        break;
    default:
        Console.WriteLine("Default");
        break;
}



// Wait before closing
Console.ReadLine();