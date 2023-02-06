// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

int InputInt(string message)
{
    System.Console.WriteLine(message + ">");
    string inputedValie = Console.ReadLine();
    int result = Convert.ToInt32(inputedValie);
    return result;
}

int x1 = InputInt("Введите точку х1");
int y1 = InputInt("Введите точку y1");
int z1 = InputInt("Введите точку z1");
int x2 = InputInt("Введите точку х2");
int y2 = InputInt("Введите точку y2");
int z2 = InputInt("Введите точку z2");

double findLenght(double xOne, double xTwo, double yOne, double yTwo, double zOne, double zTwo)
{
    double a1 = Math.Pow(xOne - xTwo, 2);
    double a2 = Math.Pow(yOne - yTwo, 2);
    double a3 = Math.Pow(zOne - zTwo, 2);
    double res = Math.Sqrt(a1 + a2 + a3);
    return res;
}

double lenght = findLenght(x1, x2, y1, y2, z1, z2);

System.Console.WriteLine($"Длина равна {lenght}");