// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


Console.WriteLine("Введите число ");
int Num = Convert.ToInt32(Console.ReadLine());
if (Num >= 100)
{
    while (Num >= 1000)
        Num = (Num /= 10);
        int FindNumber = (Num % 10);
    Console.Write($"Третья цифра: {FindNumber}");
}
else Console.Write("3-я цифра отсутствует");