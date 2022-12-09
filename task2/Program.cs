// Задача 2
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Prompt(string message)
{
    System.Console.WriteLine($"{message} ");
    double Number = Convert.ToDouble(Console.ReadLine());
    return Number;
}

double x1 = Prompt("Введи координату X для первой точки ");
double y1 = Prompt("Введи координату Y для первой точки ");
double z1 = Prompt("Введи координату Z для первой точки ");
double x2 = Prompt("Введи координату X для второй точки ");
double y2 = Prompt("Введи координату Y для второй точки ");
double z2= Prompt("Введи координату Z для второй точки ");

double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));

System.Console.WriteLine("Расстояние между двумя точками равно " + distance);