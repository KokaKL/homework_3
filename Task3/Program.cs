// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N
int InputInt(string message)
{
    System.Console.WriteLine(message + ">");
    string inputedValie = Console.ReadLine();
    int result = Convert.ToInt32(inputedValie);
    return result;
}




void print(int num)
{
for (int i = 0; i <= num; i++)
{
    int res = i * i * i;
    System.Console.WriteLine($"Куб числа {i} равен {res}");
}
}
int num = InputInt("Введите число N");
print(num);