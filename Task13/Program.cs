//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)
Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int B = number%2;
if(B == 0)
{
    Console.WriteLine("Четное");
}
else
{
    Console.WriteLine("Нечетное");
}
