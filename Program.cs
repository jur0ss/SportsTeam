﻿// See https://aka.ms/new-console-template for more information

using System;

public class Player
{
    public string Name { get; set; }
    public string Position { get; set; }
    public int Score { get; set; }
    
    public Player(string name, string position, int score)
    {
        Name = name;
        Position = position;
        Score = score;
    }
}