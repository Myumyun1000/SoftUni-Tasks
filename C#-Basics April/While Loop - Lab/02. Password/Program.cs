﻿string username = Console.ReadLine();
string correctPassword = Console.ReadLine();
string inputPassword = Console.ReadLine();

while (inputPassword != correctPassword)
{
    inputPassword = Console.ReadLine();
}

Console.WriteLine($"Welcome {username}!");
