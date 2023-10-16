using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PanasenkoRA.Sprint2.Task5.V0.Lib
{
    public class DataService : ISprint2Task5V2
    {
        public string FindMonthSeason(int value)
        {
            string res;
            switch (value)
            {
                case 1:
                    res = "Месяц - Январь, время года - Зима";
                    break;
                case 2:
                    res = "Месяц - Февраль, время года - Зима";
                    break;
                case 3:
                    res = "Месяц - Март, время года - Весна";
                    break;
                case 4:
                    res = "Месяц - Апрель, время года - Весна";
                    break;
                case 5:
                    res = "Месяц - Май, время года - Весна";
                    break;
                case 6:
                    res = "Месяц - Июнь, время года - Лето";
                    break;
                case 7:
                    res = "Месяц - Июль, время года - Лето";
                    break;
                case 8:
                    res = "Месяц - Август, время года - Лето";
                    break;
                case 9:
                    res = "Месяц - Сентябрь, время года - Осень";
                    break;
                case 10:
                    res = "Месяц - Октябрь, время года - Осень";
                    break;
                case 11:
                    res = "Месяц - Ноябрь, время года - Осень";
                    break;
                case 12:
                    res = "Месяц - Декабрь, время года - Зима";
                    break;
                default:
                    throw new ArgumentException($"Номер месяца должен быть от 1 до 12. Значение {value}");

            }
            return res;
                
        }
    }
}
