// <copyright file="cli.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System;

namespace BrainGames
{
    public static class Cli
    {
        public static void GreetUser()
        {
            Console.WriteLine("Welcome to the Brain Games! May I have your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
