double sumOfMinusElements = 0,
    maxIndex = 0, min = 0, maxModulNum = 0, sumOfIndexPlus = 0, countOfNum; 
Console.Write("Enter n: ");
int n = int.Parse(Console.ReadLine());
double []arr = new double[n];
var rand = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(-1000, 1000) / 100.0;
    Console.Write(" " + arr[i]);
}
for (int i = 0; i < n; i++)
{
    if (arr[i] < 0)
    {
        sumOfMinusElements += arr[i];
    }
}

