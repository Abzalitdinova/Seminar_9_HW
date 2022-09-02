// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("введите первое число");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число, больше, чем первое");
int M = Convert.ToInt32(Console.ReadLine());

int SummNubmers (int start, int end)
 {
    if (start == end) return end;
    return (start + SummNubmers(start+1,end));
 }

Console.WriteLine (SummNubmers(N,M));