﻿//Code example by Tim Corey https://www.youtube.com/watch?v=5RwhyZnVRS8


using ConsoleApp1;

Console.WriteLine("Welcome to my application!");

//Ask for user information
Person user  = new Person();

Console.WriteLine("What is your first name: ");
user.FirstName = Console.ReadLine();

Console.WriteLine("What is your last name: ");
user.LastName = Console.ReadLine();

//Checks to be sure the first and last names are valid
if (string.IsNullOrWhiteSpace(user.FirstName))
{
    Console.WriteLine("You didn't provide a valid first name!");
    Console.ReadLine();
    return;
}

if (string.IsNullOrWhiteSpace(user.LastName))
{
    Console.WriteLine("You didn't provide a valid last name!");
    Console.ReadLine();
    return;
}

//Create a username for the person
Console.WriteLine($"Your username is {user.FirstName.Substring(0, 1)}{user.LastName}");

Console.ReadLine();