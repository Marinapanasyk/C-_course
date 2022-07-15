// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве..

double Distance (double x1, double y1, double Z1, double x2, double y2, double Z2)
{
    return Math.Round(Math.Sqrt(Math.Pow(x1 - x2,2) + Math.Pow(y1 - y2,2)+ Math.Pow(Z1 - Z2,2)),2);
}

Console.WriteLine (Distance(3, 6, 8, 2, 1, -7));
