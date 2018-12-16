using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsBombers
{
    /// <summary>
    /// Класс-ошибка "Если на парковке уже есть автомобиль с такими же характеристиками"
    /// </summary>
    class ParkingAlreadyHaveException : Exception
    {
        public ParkingAlreadyHaveException() : base("В ангаре уже есть такой самолет")
        { }
    }
}
