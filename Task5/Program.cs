//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();
Console.Write("Введите число A: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = int.Parse(Console.ReadLine());
if(numberA>numberB)
{
    Console.Write("max = ");
    Console.WriteLine(numberA);
}
else
{
    Console.Write("max = ");
    Console.WriteLine(numberB);
}
    