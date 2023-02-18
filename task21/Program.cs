// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();
Console.WriteLine("Введите координаты точки А");
double aX = double.Parse(Console.ReadLine());
double aY = double.Parse(Console.ReadLine());
double aZ = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты точки B");
double bX = double.Parse(Console.ReadLine());
double bY = double.Parse(Console.ReadLine());
double bZ = double.Parse(Console.ReadLine());
double result = Math.Sqrt(Math.Pow(aX - bX, 2) + Math.Pow(aY - bY, 2) + Math.Pow(aZ - bZ, 2));
Console.WriteLine($" Расстояние между точками А и B -> {result}");
