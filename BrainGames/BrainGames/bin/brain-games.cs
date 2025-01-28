// <copyright file="brain-games.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using BrainGames;
using BrainGames.Games;

class Program
{
    static void Main(string[] args)
    {
        Cli.GreetUser();
        // Вызов движка для игр
        Engine.Run(LcmGame.Start);
        Engine.Run(GeoProgressionGame.Start);
    }
}

