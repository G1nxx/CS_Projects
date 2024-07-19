using Lab8;
using LAb9;

using System.Media;
bool wosShowed = false;
var tokioFactory = new TokioFactory();
List <Hotel> HotelList = new List<Hotel> ();
TokioHotel hotel = tokioFactory.CreateHotel("df", 3, 4, false) as TokioHotel;
HotelList.Add (hotel);
HotelList[0].ShowInformation();

while (true)
{
	int numberOfTask;
	bool flag = false;

    Console.WriteLine("1) Интересный факт");
	Console.WriteLine("2) что-то связанное с Польшей");
    Console.WriteLine("3) что-то связанное с Токио");
    Console.WriteLine("4) Завершить");
    if (wosShowed) Console.WriteLine("5) Музычка");



    do
    {
		 numberOfTask = IntInput.Input(ref flag);
	} while (flag == false);

	switch (numberOfTask)
	{
		case 1:
			Console.WriteLine("Если ввести число 5, то произойдет что-то интересное.");
			break;
		case 2:
			break;
		case 3:
			break;
		case 4:
            Console.WriteLine("Работа программы завершена");
            return;
        case 5:
			if (!wosShowed)
			{
                showInterestingFact();
                wosShowed = true;

            }
			else
			{
				playMusic();
			}
            break;
		default:
			Console.WriteLine("Введено неправильное значение");
			break;
	}



}
void showInterestingFact()
{
	int numberOfSong;
	bool flag = false;
	Console.WriteLine("Введите число от 1 до 8");
	do
	{
		numberOfSong = IntInput.Input(ref flag);
	} while (flag == false || numberOfSong < 1 && numberOfSong > 8);

	TokioHotel.LoadMusic(numberOfSong);
	TokioHotel.PlayMusic();

}

void playMusic()
{
    int numberOfTask;
    bool flag = false;
    Console.WriteLine("1) Выключить музыку");
    Console.WriteLine("2) Поменять песню");
    Console.WriteLine("3) Включить воспроизведение этой же песни");

    do
    {
        numberOfTask = IntInput.Input(ref flag);
    } while (flag == false);

	switch (numberOfTask)
	{
		case 1:
			TokioHotel.StopMusic();
			break;
		case 2:
            int numberOfSong;
            do
            {
                Console.WriteLine("Введите число от 1 до 8");
                numberOfSong = IntInput.Input(ref flag);
            } while (flag == false || numberOfSong < 1 ||numberOfSong > 8);
            TokioHotel.LoadMusic(numberOfSong);
            TokioHotel.PlayMusic();
            break;
		case 3:
			TokioHotel.PlayMusic();
			break;
		default:
            Console.WriteLine("Введено неправильное значение. В наказание вернись в главное меню ))");
            break;
    }

   

}
