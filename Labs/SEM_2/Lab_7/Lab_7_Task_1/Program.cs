namespace Lab_7_Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MySetOfCharacters characters1 = new("abc");
            MySetOfCharacters characters2 = new("cde");

            MySetOfCharacters characters3 = characters1 + characters2;
            MySetOfCharacters characters4 = characters1 - characters2;
            MySetOfCharacters characters5 = characters1 * characters2;

            Console.WriteLine(characters1.ToString());
            Console.WriteLine(characters2.ToString());
            Console.WriteLine(characters3.ToString());
            Console.WriteLine(characters4.ToString());
            Console.WriteLine(characters5.ToString());
            Console.WriteLine();

            Console.WriteLine(characters1[1]);
            Console.WriteLine(characters5 != characters2);
        }
    }
}
