namespace Lab_5_Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hotel hotel = new Hotel();
            int countOfRooms = hotel.GetCountOfRooms();
            Console.WriteLine("Count Of Rooms " + countOfRooms);

            hotel.CheckIntoTheHotel(3,"Dmitry");
            int countOfOrderedRooms = hotel.GetCountOfOrderedRooms();
            Console.WriteLine("Count Of Ordered Rooms " + countOfOrderedRooms);

            for (int i = 5; i < 12; i++)
            {
                hotel.CheckIntoTheHotel(i, "Guest № " + i);
            }
            countOfOrderedRooms = hotel.GetCountOfOrderedRooms();
            Console.WriteLine("Count Of Ordered Rooms " + countOfOrderedRooms);

            for (int i = 11; i <= 12; i++)
            {
                if (hotel.CheckIntoTheHotel(i, "Guest № " + i)) { Console.WriteLine("All Ready Ordered " + (i + 1)); }
            }
            countOfOrderedRooms = hotel.GetCountOfOrderedRooms();
            Console.WriteLine("Count Of Ordered Rooms " + countOfOrderedRooms);

            Console.WriteLine(hotel.CheckIntoTheHotel(22, "Guest № " + 22) ? "Successful" : "Error");
        }
    }
}
