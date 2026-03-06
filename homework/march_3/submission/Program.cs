int num = 0;

while (num < 5)
{
    num += 1;
    Console.Write(num + " ");
}
Console.WriteLine();
num = 99;

while (num < 150)
{
    num += 1;
    Console.Write(num + " ");
}
Console.WriteLine();
num = -2;

while (num < 100)
{
    num += 2;
    Console.Write(num + " ");
}
Console.WriteLine();
num = 21;

while (num > -20)
{
    num -= 1;
    Console.Write(num + " ");
}
Console.WriteLine();
num = -2;

while (num < 100)
{
    num += 3;
    Console.Write(num + " ");
}
Console.WriteLine();
num = 1;
while (num < 1025)
{
    Console.Write(num + " ");
    num *= 2;
}
Console.WriteLine();
string answer;
do
{
    Console.WriteLine("Do you want the loop to stop?");
    answer = Console.ReadLine();
}
while (answer != "yes");

bool tf = true;
num = 1;
while (num < 100)
{
    Console.Write(tf + " ");
    if (tf)
    {
        tf = false;
    }
    else
    {
        tf = true;
    }

    num += 1;
}
Console.WriteLine();
num = 1;
bool isEven = false;
while (num < 21)
{
    if (isEven == true)
    {
        Console.WriteLine(num + " is even!");
    }
    else
    {
        Console.WriteLine(num + " is odd!");
    }

    if (isEven)
    {
        isEven = false;
    }
    else
    {
        isEven = true;
    }
    num += 1;
    
}

string[] list = ["once", "upon", "a", "midnight", "dreary"];
num = 0;
while (num < 5){
    Console.Write(list[num] + " ");
    num += 1;

}
