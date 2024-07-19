using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_Task_1
{
    internal class Tariff
    {
        private const int MaxTariff = 1000;
        private const int MinTariff = 100;
        private int _tariff;

        public Tariff()
        {
            this._tariff = 200;
        }

        public int GetTariff()
        {
            return this._tariff;
        }

        public void SetTariff(int newTariff)
        {
            this._tariff = newTariff;
            if (this._tariff > MaxTariff) { this._tariff = MaxTariff; }
            else if (this._tariff < MinTariff) { this._tariff = MinTariff; }
            return;
        }

        public void IncreaseTariff()
        {
            this._tariff += 10;
            if (this._tariff > MaxTariff) { this._tariff = MaxTariff; }
            return;
        }

        public void DiminishTariff()
        {
            this._tariff -= 10;
            if (this._tariff < MinTariff) { this._tariff = MinTariff; }
            return;
        }
    }
}