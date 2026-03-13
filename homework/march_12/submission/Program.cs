// See https://aka.ms/new-console-template for more information

int[] numbers = { 42, 7, 5, 98, 21 };

int smallest = numbers[0];
int largest = numbers[0];
int i = 1;
while (i < 5)
{
    if (numbers[i] < smallest)
    {
        smallest = numbers[i];
    }
    if (numbers[i] > largest)
    {
        largest = numbers[i];
    }

    i++;
}
Console.WriteLine("The largest number is " + largest + ". The smallest number is " + smallest + ".");