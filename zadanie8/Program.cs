// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.Clear();
Console.Write("Введите число: - ");
int numbers = int.Parse(Console.ReadLine());
int counter = 1;
while (counter <= numbers)
{
    if (counter % 2 == 0 && counter < numbers) // "Это дополнительное условие я добавил что-бы - 
    {
        Console.Write(counter + ", ");
        counter++;
    }
    else if (counter == numbers)                // внутрений перфекционист ликовал.
    {
        Console.Write(counter + ".");
        counter++;
    }
    else
    {
        counter++;
    }
}
