// Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число дня недели");
int Number = Convert.ToInt32(Console.ReadLine());
if ((Number>0) && (Number<6))
{
    Console.WriteLine("Будний день");
}
else if (Number == 6 || Number == 7) 
{
    Console.WriteLine("Выходной день");
} 
else Console.WriteLine("Не верное число");