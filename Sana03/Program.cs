double sumOfMinusElements = 0, min = 0, maxModulNum = 0, sumOfIndexPlus = 0, countOfNum = 0;
int maxIndex = 0;
Console.Write("Enter n: ");
int n = int.Parse(Console.ReadLine());
double []arr = new double[n];
var rand = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(-1000, 1000) / 100.0 ;
    Console.Write(" " + arr[i]);
}
min = arr[0];
maxModulNum = Math.Abs(arr[0]);
for (int i = 0; i < n; i++)
{
    if (arr[i] < 0)
    {
        sumOfMinusElements += arr[i];
    }
    if (arr[i] < min)
    {
        min = arr[i];
    }
    if (arr[i] > arr[maxIndex])
    {
        maxIndex = i;
    }
    if (arr[i] > 0)
    {
        sumOfIndexPlus += i;
    }
    if (Math.Abs(arr[i]) > maxModulNum)
    {
        maxModulNum = Math.Abs(arr[i]);
    }
    if (arr[i] % 1 == 0) {
    countOfNum++;
    }
}
Console.WriteLine("\nSum of minus elements = " + sumOfMinusElements);
Console.WriteLine("Minimum = " + min);
Console.WriteLine("Index of max element = " + maxIndex);
Console.WriteLine("Max by modul = " + maxModulNum);
Console.WriteLine("Sum of index plus elements = " + sumOfIndexPlus);
Console.WriteLine("Count of integer = " + countOfNum);

