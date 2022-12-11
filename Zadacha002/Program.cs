Console.Write("");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.Write($"{x}, Y: {y}");
 //Напишите программу, которая найдёт точку пересечения 
 //двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
 //значения b1, k1, b2 и k2 задаются пользователем.
