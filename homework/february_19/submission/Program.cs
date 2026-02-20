// string - text
// int - numbers (integer)
// bool - boolean - True / False

// name
// type
// value

// bmakin@chapman.edu

string userA, userB;
double a, b;
double c = 0;
string operation;
bool good = false;

Console.WriteLine("This program acts as a calculator, handling addition, subtraction, multiplication, and division. It also can handle decimals.");
Console.WriteLine("What is your first number?");
userA = Console.ReadLine();
a = double.Parse(userA); // Converts str to another data type

Console.WriteLine("What is your second number?");
userB = Console.ReadLine();
b = double.Parse(userB);

Console.WriteLine("What operation do you want to use?");
operation = Console.ReadLine();

if (operation == "division")
{
    if (b == 0)
    {
        Console.WriteLine("Uh oh, you can't divide by 0!");
    }
    else
    {
        c = a / b;
        Console.Write(a + " divided by ");
        good = true;
    }
        
}

else if (operation == "multiplication")
{
    c = a * b;
    Console.Write(a + " times ");
    good = true;

}

else if (operation == "addition")
{
    c = a + b;
    Console.Write(a + " plus ");
    good = true;

}
else if (operation == "subtraction")
{
    c = a - b;
    Console.Write(a + " minus ");
    good = true;
}
else
{
    Console.WriteLine("Not a valid operation!");
}

if (good)
{
    Console.WriteLine(b + " is " + c + ".");
}