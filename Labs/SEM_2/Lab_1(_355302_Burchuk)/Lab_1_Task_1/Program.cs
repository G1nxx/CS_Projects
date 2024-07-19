namespace _353502_Burchuk
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Int32 delimoe,
                  delitel,
                  chastnoe;

            while (!Int32.TryParse(Console.ReadLine(), out delimoe)) ;

            while (!Int32.TryParse(Console.ReadLine(), out delitel)) ;

            if (delitel != 0) { 
                chastnoe = delimoe / delitel;
                Console.WriteLine("Chastnoe = " + chastnoe);
            }
            else { Console.WriteLine("Error!!!"); }
        }
    }
}