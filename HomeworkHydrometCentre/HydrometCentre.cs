using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkHydrometCentre
{
    internal class HydrometCentre
    {
        TemperatureInformation[] temperatureInformation = new TemperatureInformation[30];

        public void AddTemperatureInformation(string date, double C, double F, double K) 
        { 
            for (int i = 0; i < temperatureInformation.Length; i++)
            {
                if (temperatureInformation[i].Date == null)
                {
                    temperatureInformation[i] = new TemperatureInformation(date, C, F, K);
                    break;
                }
            }
        }

        public void RemoveTemperatureInformation(string date)
        {
            for (int i = 0;i < temperatureInformation.Length; i++)
            {
                if (temperatureInformation[i].Date == date)
                {
                    temperatureInformation[i] = new TemperatureInformation();
                    break;
                }
            }
        }

        public void PrintAllTemperatureInformation()
        {
            for (int i = 0; i < temperatureInformation.Length ; i++)
            {
                if (temperatureInformation[i].Date == null)
                {
                    Console.WriteLine("...");
                }
                else
                {
                    temperatureInformation[i].GetInfo();
                }
            }
        }

        public void GetTempretureByDate(string date)
        {
            for (int i = 0;i < temperatureInformation.Length; i++)
            {
                if (temperatureInformation[i].Date == date)
                {
                    temperatureInformation[i].GetInfo();
                }
            }
        }

        public void GetTempretureByPeriod(string start, string end) 
        {
            int indexStart = -1, indexEnd = -1;
            for (int i = 0; i < temperatureInformation.Length; i++)
            {
                if (temperatureInformation[i].date == start)
                {
                    indexStart = i;
                }
                if (temperatureInformation[i].date == end)
                {
                    indexEnd = i;
                    break;
                }
            }
            for (int i = indexStart; i <= indexEnd; i++)
            {
                temperatureInformation[i].GetInfo();
            }
        }
    }
}
