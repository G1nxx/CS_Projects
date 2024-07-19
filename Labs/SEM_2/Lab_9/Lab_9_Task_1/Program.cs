using Lab_9_Task_1.Companies;
using Lab_9_Task_1.Factories;

namespace Lab_9_Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TransferCompany> transferCompanies = new List<TransferCompany>();
            WorldFactory worldFactory = new WorldFactory();
            BelarusFactory belarusFactory = new BelarusFactory();
            MinskFactory minskFactory = new MinskFactory();
            transferCompanies.Add(minskFactory.CreateAutoLightExpress("Книга", 200, new Track()));
            transferCompanies.Add(minskFactory.CreateEMS("Пылесос", 500, new Track()));
            transferCompanies.Add(minskFactory.CreateSamoTrans("Картошка", 50, new Track()));
            transferCompanies.Add(belarusFactory.CreateAutoLightExpress("Конфеты \"Андрейка\"", 20, new Track()));
            transferCompanies.Add(belarusFactory.CreateEMS("Вода", 40, new Track()));
            transferCompanies.Add(belarusFactory.CreateSamoTrans("Лидский Квас", 400, new Track()));
            transferCompanies.Add(worldFactory.CreateAutoLightExpress("Аэроплан", 20000, new Wan()));
            transferCompanies.Add(worldFactory.CreateEMS("Слон", 35900, new Wan()));
            transferCompanies.Add(worldFactory.CreateSamoTrans("Контейнер с нефтью", 900000, new Wan()));

            foreach (TransferCompany transferCompany in transferCompanies)
            {
                transferCompany.ShowMessage();
                transferCompany.GetInfo();
                Console.WriteLine("Имя товара: " + transferCompany.Name);
                Console.WriteLine("Стоимость товара: " + transferCompany.Cost);
                Console.WriteLine("Тип машины: " + transferCompany.TypeOfCar);

                if (transferCompany is EMS)
                {
                    (transferCompany as EMS).Careful();
                }
                else if (transferCompany is SamoTrans)
                {
                    (transferCompany as SamoTrans).Fast();
                }
                else if (transferCompany is AutoLightExpress)
                {
                    (transferCompany as AutoLightExpress).Cheap();
                }

                Console.WriteLine();
            }
        }
        
    }
}
