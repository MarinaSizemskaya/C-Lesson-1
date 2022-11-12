//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
Console.Clear();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
int B = 1;
while(B<=N)
{
    int x = B%2;
    if(x==0) Console.Write($"{B}, ");
    //Console.Write(" ");
B++;
}
