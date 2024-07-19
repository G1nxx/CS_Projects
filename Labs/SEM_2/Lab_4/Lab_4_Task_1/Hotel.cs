using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_Task_1
{
    internal class Hotel
    {
        private const int MaxNumberOfPlaces = 21;

        private readonly string _name;

        private readonly Tariff _hotelTariff = new();

        private int _numberOfBusyPlaces;

        private static Hotel? _instance;
        protected Hotel()
        {
            this._name = "BSUIR Hotel *****";
            this._numberOfBusyPlaces = 0;
        }
        public static Hotel? GetInstance()
        {
            _instance ??= new Hotel();
            return _instance;
        }
        public string GetName()
        {
            return this._name;
        }
        public int GetNumberOfBusyPlaces()
        {
            return this._numberOfBusyPlaces;
        }
        public int GetMaxNumberOfPlaces()
        {
            return MaxNumberOfPlaces;
        }

        public bool Populate(int numberToPopulate)
        {
            if (numberToPopulate + this._numberOfBusyPlaces <= MaxNumberOfPlaces)
            {
                this._numberOfBusyPlaces += numberToPopulate;
                return true;
            }
            else
            {
                return false;
            }
        }
        public int GetTariff()
        {
            return _hotelTariff.GetTariff();
        }
        public int GetRevenue()
        {
            var revenue = _numberOfBusyPlaces * _hotelTariff.GetTariff();
            return revenue;
        }

        public void SetTariff(int newTariff)
        {
            this._hotelTariff.SetTariff(newTariff);
        }

        public void IncreaseTariff()
        {
            this._hotelTariff.IncreaseTariff();
        }

        public void DiminishTariff()
        {
            this._hotelTariff.DiminishTariff();
        }
    }
}
