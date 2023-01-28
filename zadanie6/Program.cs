// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет
Console.Clear();
Console.Write("Введите число: - ");
int numbers = int.Parse(Console.ReadLine());
if (numbers % 2 == 0)
{
    Console.Write("Число " + numbers + ", является чётным числом.");
}
else
{
    Console.Write("Число " + numbers + ", не является чётным члом.");
}




// Console.WriteLine("Hello, World!");
