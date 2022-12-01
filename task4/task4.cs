Console.Clear();
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());
int i = 0;
while (N > i)
{
    i = i + 2; 
    Console.Write($"{i}, ");
}