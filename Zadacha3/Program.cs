// Напишите программу, которая на вход принимает одно число (N), а на выходе 
//показывает все целые числа в диапазоне -N  до N
Console.Clear();
Console.Write("Введите  число: ");
int i = int.Parse(Console.ReadLine());
int n = -i;
while  (n<=i)
{
    Console.WriteLine(n);
    n++;
}