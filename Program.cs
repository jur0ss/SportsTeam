// See https://aka.ms/new-console-template for more information

using System;

internal class Program
{
    public interface PlayerInterface
    {
        string Name { get; }
        string Position { get; }
        int Score { get; }
    }

    public class Player : PlayerInterface
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

        public void UpdateScore(int upd)
        {
            Score += upd;
        }
    }

    public class Team
    {
        public List<PlayerInterface> Players = new List<PlayerInterface>();

        public void AddPlayer(PlayerInterface player)
        {
            Players.Add(player);
            Console.WriteLine($"Dodano zawodnika: {player.Name}");
        }
    }
}