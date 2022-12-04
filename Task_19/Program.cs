// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Напишите пятизначное число для проверки, является ли оно палиндромом");

int number = int.Parse(Console.ReadLine());

void PalindromeCheck(int number)
{
   // Console.WriteLine(str);
    int ost = number / 1000;
    int ostend = number % 100;
    int ostend2 = (ostend % 10) * 10 + (ostend / 10);
    if (ost == ostend2)
    Console.WriteLine($"число {number} является палиндромом");
    else 
    Console.WriteLine($"число {number} не является палиндромом");
    
}
PalindromeCheck(number);