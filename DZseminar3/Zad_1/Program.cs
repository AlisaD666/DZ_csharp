﻿//Напишите программу, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();

if (number.Length == 5)
{
    CheckPalindrome(number);
}
else Console.WriteLine("Ошибка! Введите пятизначное число");

void CheckPalindrome(string palindrome)
{
    if (palindrome[0] == palindrome[4] || palindrome[1] == palindrome[3])
    {
        Console.WriteLine("Палиндром");
    }
    else
    {
        Console.WriteLine("Не палиндром");
    }
}