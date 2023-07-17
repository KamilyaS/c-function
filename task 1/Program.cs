/* Напишите программу, которая принимает на вход число А и 
выдает сумму чисел от 1 до А
7 ->28
4 ->10
8 ->36 */


/*Console.Write("Add  number: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;

for(int i = 1; i <= number; i++)
{
    sum = sum + i;
}
Console.WriteLine($"Summa from 1 to {number}: {sum}");

int ReadInt(string text)
{
    System.Console.Write(text);
    int tempNumber = Convert.ToInt32(Console.ReadLine());
    return tempNumber;
}
int number = ReadInt("Add number: ");
int sum = 0;

for(int i = 1; i <= number; i++)
{
    sum = sum + i;
}
Console.WriteLine($"Summa from 1 to {number}: {sum}");*/

/* int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int number = ReadInt("Add number: ");
int sum = 0;

for(int i = 1; i <= number; i++)
{
    sum = sum + i;
}
Console.WriteLine($"Summa from 1 to {number}: {sum}");*/

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int SumNumbers(int A)
{
    int sum = 0;

    for(int i = 1; i <= A; i++)
    {
        sum += i;
    }
    return sum;
}
int number = ReadInt("Add number: ");
int sum = SumNumbers(number);
Console.WriteLine($"Summ from 1 to {number}: {sum}");