using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_9_Task_1.Interfaces;

namespace Lab_9_Task_1
{
    internal class Wan : ICar
    {
        public void SetCar(TransferCompany company) => company.TypeOfCar = "Фура";
    }
}
