//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

using System;
using static System.Console;
Clear();

WriteLine("Введите координаты А: ");
int X1 = int.Parse(ReadLine());
int Y1 = int.Parse(ReadLine());
int Z1 = int.Parse(ReadLine());

WriteLine("Введите координату B: ");
int X2 = int.Parse(ReadLine());
int Y2 = int.Parse(ReadLine());
int Z2 = int.Parse(ReadLine());

WriteLine($"А ({X1},{Y1},{Z1}); B ({X2},{Y2},{Y2})");

int X = X1 - X2;
int Y = Y1 - Y2;
int Z = Z1 - Z2;

double C = Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2)+ Math.Pow(Z,2));
WriteLine($"{C:f2}");