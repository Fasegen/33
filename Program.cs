Random rd = new Random();
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
for (int i = 0; i < N; i++)
    {
        array[i] = rd.Next(1, 100);
    }
    for (int i = 0; i < N; i++)
    {   
        if ( i == N - 1)
        Console.Write($"{array[i]}. ");
        else 
        Console.Write($"{array[i]}, ");
    }
Console.WriteLine("");    




int x = Convert.ToInt32(Console.ReadLine());
int result = 0;
while (x > 0)
{
    result += x % 10;
    x = x / 10;
}
Console.WriteLine(result);




Console.WriteLine("Введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int b = Convert.ToInt32(Console.ReadLine());
int result = a;
for (int i = 1; i < b; i++)
{
result = result * a;
}
Console.WriteLine(result);

