//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

using System;
using static System.Console;
Clear();

WriteLine("Введите пятизначное число: ");
int number = int.Parse(ReadLine());

if  (number < 10000 || number > 99999)
{
WriteLine("Число не пятизначное! Попробуйте еще раз");
}
else
{
    string answer = number / 10000 == number % 10 & number / 1000 % 10 == number % 100 / 10 ? "да" : "нет";
WriteLine(answer);
}
