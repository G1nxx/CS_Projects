namespace Test_NULL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? a = null;
            int b = a ?? 100;
            Console.WriteLine(b);
        }
    }
}
