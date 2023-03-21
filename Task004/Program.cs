// Задача 27 HARD: Напишите программу, которая принимает на вход число (целое, вещественное, в экспоненциальной форме) и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9,012 -> 12
// 6,02214129e23 -> 27


Console.WriteLine("Введите число (целое, вещественное, в экспоненциальной форме) ");
double number = Convert.ToDouble(Console.ReadLine());
double sum = 0;
TransNumber(number);
string allNumb = number.ToString("0000");
int[] array = new int[allNumb.Length];
Console.WriteLine($"Сумма цифр в введеннои числе равна: {SumNumber(sum)}");


double TransNumber(double number)
{
    while (number % 1 > 0)
    {
        number *= 10;
    }
    return number;
}


double SumNumber(double sum)
{

    for (int i = 0; i < allNumb.Length; i++)
    {
        array[i] = int.Parse(allNumb[i] + "");
        sum = sum + array[i];
    }
    return sum;
}

