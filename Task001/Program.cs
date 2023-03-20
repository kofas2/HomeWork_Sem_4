// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число А: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Число {numA} в степени {numB} равно: {DegreeNumber2(numA, numB)}");



int DegreeNumber2(int numA, int numB)
{

    int result = 1;
    // result = Math.Pow(numA, numB);
    for (int i = 0 ; i < numB; i++)
    {
        result *= numA;
    }
    return result;
}



// int MessageToUser(string message)
// {
//     System.Console.Write(message);
//     string userInput = System.Console.ReadLine();
//     int result = int.Parse(userInput);
//     return result;
// }

// int DegreeResult(int numA, int numB)
// {
// int degreeRes = 1;
// for (int i =0; i < numB; i++)
// {
//     degreeRes *= numA;
// }
// return degreeRes;
// }

// bool ValidNumB(int numB)
// {
//     if (numB<0)
//     {
//     System.Console.WriteLine("Показатель не должен быть меньше нуля");
//     return false;
// }
// return true;
// }

// int numA = MessageToUser("Введите число А ");
// int numB = MessageToUser("введите число Б ");
// if (ValidNumB(numB))
// {
//     System.Console.WriteLine($"Число {numA} в степени {numB} равно: {DegreeResult(numA, numB)}");
// }