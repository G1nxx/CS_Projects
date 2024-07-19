namespace Lab_6_Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SportGames sportGames = new SportGames();
            sportGames.DoSport();
            sportGames.Information();
            Console.WriteLine();

            Football football = new Football(); 
            football.DoSport();
            Console.WriteLine();

            Volleyball volleyball = new Volleyball();
            volleyball.DoSport();
            volleyball.ServeTheBall();
            Console.WriteLine();

            BeachVolleyball beachVolleyball = new BeachVolleyball();
            beachVolleyball.DoSport();
            beachVolleyball.ServeTheBall();
            Console.WriteLine();

            Pioneerball pioneerball = new Pioneerball();    
            pioneerball.DoSport();
            pioneerball.ServeTheBall();
            Console.WriteLine();
        }
    }
}
