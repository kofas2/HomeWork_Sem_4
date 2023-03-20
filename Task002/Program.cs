// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int MessageToUser(string message)
{
    System.Console.Write(message);
    string userInput = System.Console.ReadLine();
    int result = int.Parse(userInput);
    return result;
}

int number = MessageToUser("Ввведите целое число: ");
Console.WriteLine($"Сумма цифр в данном числе равна: {SumNumOfNum(number)}");


int SumNumOfNum(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number%10;
        number = number/10;
    }
    return sum;
}