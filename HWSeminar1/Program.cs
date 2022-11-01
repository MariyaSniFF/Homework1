//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите два числа");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 =  Convert.ToInt32(Console.ReadLine());

if(num1>num2)
{
    Console.WriteLine($"{num1}больше чем {num2}");
}
else
{
    Console.WriteLine($"{num2} больше чем {num1}");
}
