namespace Lab_8_Task_1
{
    internal class Program
    {
        static public void Main(string[] args)
        {
            Hotel hotel = new Hotel();
            hotel.OrderRoom(1);
            Console.WriteLine("Money hotel will get: " + hotel.GetMoney());
            for (int i = 4; i < 18; i++)
            {
                hotel.OrderRoom(i);
            }
            Console.WriteLine("Money hotel will get: " + hotel.GetMoney());
        }
    }
}
