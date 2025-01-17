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

        public void RemovePlayer(PlayerInterface player)
        {
            Players.Remove(player);
            Console.WriteLine($"Z drużyny został usunięty zawodnik: {player.Name}");
        }

        public void ShowStats()
        {
            foreach (var player in Players)
            {
                Console.WriteLine($"Zawodnik: {player.Name}, Pozycja {player.Position}, Punkty {player.Score}");
            }
        }

        public double AverageScore()
        {
            return Players.Average(p => p.Score);
        }
    }

    static void Main(string[] args)
    {
        Team team = new();
        
        team.AddPlayer(new Player("Jan Kowalski", "Obrońca", 12));
        team.AddPlayer(new Player("Adam Nowak", "Napastnik", 25));
        team.AddPlayer(new Player("Tomasz Zieliński", "Pomocnik", 18));
    }
}
