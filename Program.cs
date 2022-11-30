// TASK 43

/*Console.WriteLine("Please enter the B1");
double B1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter the K1");
double K1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter the B2");
double B2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter the K2");
double K2 = Convert.ToInt32(Console.ReadLine());

double x = (-B2 + B1)/(-K1 + K2);
double y = K2 * x + B2;

Console.WriteLine($"Two straight lines will intersect at a point with coordinates - X: {x} and Y: {y}");*/


// TASK 41

int[] GetRandomArray(int length, int min, int max)
{
    Console.WriteLine("Please enter the number that will be the size of array");
    length = int.Parse(Console.ReadLine());
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Please enter a random number");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int NumberGreaterThanZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    if (array[i] > 0)
    {
        count++;
    }
    return count;
}

int[] EndArray = GetRandomArray(10, 1, 1500);
Console.WriteLine();
PrintArray(EndArray);
int NumberGreatZero = NumberGreaterThanZero(EndArray);
Console.WriteLine();
Console.WriteLine($"The number of numbers greater than 0 - {NumberGreatZero}");