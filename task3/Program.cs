// Задача 3

// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Prompt(string message)
{
    System.Console.WriteLine($"{message} ");
    int Number = Convert.ToInt32(Console.ReadLine());
    return Number;
}

int num = Prompt("Введи число ");
int index = 1;
while (index <= num)
{
    int cube = index * index * index;
    System.Console.WriteLine(cube);
    index++;
}