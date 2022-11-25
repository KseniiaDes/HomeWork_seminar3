// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool Palindrome(int num)
{
    int num1 = num % 10;
    int num2 = num / 10 % 10;
    int num4 = num / 1000 % 10;
    int num5 = num / 10000 % 10;
    return (num1 == num5 && num2 == num4);
}

if (number > 9999 && number < 100000)
    Console.WriteLine(Palindrome(number)
        ? $"Да, число {number} является полиндромом"
        : $"Нет, число {number} не является полиндромом");
else Console.WriteLine("Ошибка ввода! Введите пятизначное число");