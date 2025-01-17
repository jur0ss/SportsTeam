// See https://aka.ms/new-console-template for more information

using System;

internal class Program
{
    public interface PlayerInterface
    {
        string Name { get; }
        string Position { get; }
        int Score { get; set; }
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
        
        public void UpdateScore(string playerName, int upd)
        {
            var player = Players.FirstOrDefault(p => p.Name == playerName);
            if (player != null) 
            {
                player.Score += upd; 
                Console.WriteLine($"Zaktualizowano wynik zawodnika {playerName}. Nowy wynik: {player.Score}");
            }
            else
            {
                Console.WriteLine($"Zawodnik o imieniu {playerName} nie został znaleziony");
            }
        }
    }

    static void Main(string[] args)
    {
        Team team = new();
        
        team.AddPlayer(new Player("Jan Kowalski", "Obrońca", 12));
        team.AddPlayer(new Player("Adam Nowak", "Napastnik", 25));
        team.AddPlayer(new Player("Tomasz Zieliński", "Pomocnik", 18));
        
        team.ShowStats();

        double average = team.AverageScore();
        Console.WriteLine($"Średnia zdobytych punktów w drużynie {average}");
        
        team.UpdateScore("Adam Nowak", 6);
        
    }
}
