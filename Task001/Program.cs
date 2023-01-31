// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int InputInt(string message)
{
    System.Console.WriteLine(message + ">");
    string inputedValie = Console.ReadLine();
    int result = Convert.ToInt32(inputedValie);
    return result;
}
int reverse(int num)
{
    int Reverse = 0;
    while (num > 0)
    {
        Reverse = Reverse * 10;
        Reverse = Reverse + num % 10;
        num = num / 10;
    }
    return Reverse;
}
bool PalindromChek(int num)
{
    int REVERSE = reverse(num);
    return num == REVERSE;
}


int number = InputInt("Введите число для проверки ");
if (PalindromChek(number))
 {
    System.Console.WriteLine("является палиндромом");    
 }
 else
 {
    System.Console.WriteLine("не является палиндромом");
 }
 

