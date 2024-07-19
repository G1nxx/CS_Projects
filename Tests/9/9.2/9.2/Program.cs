using Lab8;
using LAb9;

using System.Media;
bool wosShowed = false;
AbstractFactory currentFactory;
List<Hotel> HotelList = new List<Hotel>();
List<Hostel> HostelList = new List<Hostel>();
List<Farmstead> FarmsteadList = new List<Farmstead>();

while (true)
{
    int numberOfTask;
    bool flag = false;

    Console.WriteLine("1) Интересный факт");
    Console.WriteLine("2) добавить Польский отель");
    Console.WriteLine("3) добавить Польский хостел");
    Console.WriteLine("4) добавить Польская агроусадьба");
    Console.WriteLine("5) добавить Токийский отель");
    Console.WriteLine("6) добавить Токийский хостел");
    Console.WriteLine("7) добавить Токийская агроусадьба");
    Console.WriteLine("8) Показать информацию о отелях");
    Console.WriteLine("9) Показать информацию о хостелах");
    Console.WriteLine("10) Показать информацию о агроусадьбах");
    Console.WriteLine("11) Завершить");
    if (wosShowed) Console.WriteLine("12) Музычка");

    do
    {
        numberOfTask = IntInput.Input(ref flag);
    } while (flag == false);

    switch (numberOfTask)
    {
        case 1:
            Console.WriteLine("Если ввести число 12, то произойдет что-то интересное.");
            break;
        case 2:
            currentFactory = new PolishFactory();
            HotelList.Add(CreateHotel(currentFactory));
            break;
        case 3:
            currentFactory = new PolishFactory();
            HostelList.Add(CreateHostel(currentFactory));
            break;
        case 4:
            currentFactory = new PolishFactory();
            FarmsteadList.Add(CreateFarmstead(currentFactory));
            break;
        case 5:
            currentFactory = new TokioFactory();
            HotelList.Add(CreateHotel(currentFactory));
            break;
        case 6:
            currentFactory = new TokioFactory();
            HostelList.Add(CreateHostel(currentFactory));
            break;
        case 7:
            currentFactory = new TokioFactory();
            FarmsteadList.Add(CreateFarmstead(currentFactory));
            break;
        case 8:
            ShowHotel(HotelList);
            break;
        case 9:
            ShowHostel(HostelList);
            break;
        case 10:
            ShowFarmstead(FarmsteadList);
            break;
        case 11:
            Console.WriteLine("Работа программы завершена");
            return;
        case 12:
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
            } while (flag == false || numberOfSong < 1 || numberOfSong > 8);
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

Hotel CreateHotel(AbstractFactory currentFactory)
{
    Console.WriteLine("Введите имя отеля");
    string title = Console.ReadLine();
    int price;
    bool flag = false;
    do
    {
        Console.WriteLine("Введите цену");
        price = IntInput.Input(ref flag);
    } while (flag == false || price <= 0);

    int numberOfFloors = 0;
    do
    {
        Console.WriteLine("Введите количество этажей");
        numberOfFloors = IntInput.Input(ref flag);
    } while (flag == false || numberOfFloors <= 0);

    string ans = "";

    while (ans != "да" && ans != "нет")
    {
        Console.WriteLine("Есть ли бассейн?");
        ans = Console.ReadLine();
    }

    flag = (ans == "да");
    Hotel hotel = currentFactory.CreateHotel(title, price, numberOfFloors, flag);

    if (ans == "да")
    {

        while (ans != "Круг" && ans != "Прямоугольник")
        {
            Console.WriteLine("Какая форма бассейна? (Круг/Прямоугольник)");
            ans = Console.ReadLine();
        }
        hotel.ipool = (ans == "Круг" ? new CirclePool(): new RectanglePool() );
        hotel.CreatePool();

    }


    return hotel;
}

Hostel CreateHostel(AbstractFactory currentFactory)
{
    Console.WriteLine("Введите имя отеля");
    string title = Console.ReadLine();
    int price;
    bool flag = false;
    do
    {
        Console.WriteLine("Введите цену");
        price = IntInput.Input(ref flag);
    } while (flag == false || price <= 0);

    int numberOfRooms = 0;
    do
    {
        Console.WriteLine("Введите количество комнат");
        numberOfRooms = IntInput.Input(ref flag);
    } while (flag == false || numberOfRooms <= 0);

    Hostel hostel = currentFactory.CreateHostel(title, price, numberOfRooms);

    return hostel;
}

Farmstead CreateFarmstead(AbstractFactory currentFactory)
{
    Console.WriteLine("Введите имя отеля");
    string title = Console.ReadLine();
    int price;
    bool flag = false;
    do
    {
        Console.WriteLine("Введите цену");
        price = IntInput.Input(ref flag);
    } while (flag == false || price <= 0);

    int distance = 0;
    do
    {
        Console.WriteLine("Введите расстояние до города в км (целое число)");
        distance = IntInput.Input(ref flag);
    } while (flag == false || distance <= 0);

    Farmstead farmstead = currentFactory.CreateFarmstead(title, price, distance);

    return farmstead;
}

void ShowHotel(List<Hotel> list)
{
    for (int i = 0; i < list.Count; ++i)
    {
        Console.WriteLine($"{i + 1}");
        list[i].ShowInformation();
        Console.WriteLine("---------------------");
    }
}

void ShowHostel(List<Hostel> list)
{
    for (int i = 0; i < list.Count; ++i)
    {
        Console.WriteLine($"{i + 1})");
        list[i].ShowInformation();
        Console.WriteLine("---------------------");
    }
}

void ShowFarmstead(List<Farmstead> list)
{
    for (int i = 0; i < list.Count; ++i)
    {
        Console.WriteLine($"{i + 1}");
        list[i].ShowInformation();
        Console.WriteLine("---------------------");
    }
}