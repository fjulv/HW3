// Задача 1

// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом. 
// Не использовать строки

// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Prompt(string message)
{
    System.Console.WriteLine($"{message} ");
    int Number = Convert.ToInt32(Console.ReadLine());
    return Number;
}

int number = Prompt("Введи пятизначное число ");


int n5 = number / 10000 % 10;
int n4 = number / 1000 % 10;
int n3 = number / 100 % 10;
int n2 = number / 10 % 10;
int n1 = number % 10;
int rev = n1 * 10000 + n2 * 1000 + n3 * 100 + n4 * 10 + n5;

if (number > 9999 && number < 100000)
{
    if (rev == number)
    {
        System.Console.WriteLine("Число " + number + " является палиндромом");
    }
    else
        System.Console.WriteLine("Число " + number + " не является палиндромом");

}
else
    System.Console.WriteLine("Введенное число не является пятизначным");


