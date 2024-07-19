namespace Test_Indexes___Diaposones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Enumerable.Range(1, 10).ToArray();

            int[] newArray = array[^4..^3];
            foreach (var index in array[..4])
            {
                Console.WriteLine(index);
            }
        }
    }
}
