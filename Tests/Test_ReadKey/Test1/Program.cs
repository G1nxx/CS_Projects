namespace Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Press {"any"} key to close");
            while (true)
            {
                Console.ReadKey();
                Console.Write('\b');
            }
        }
    }
}
