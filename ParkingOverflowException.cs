using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsBombers
{
    /// <summary>
    /// Класс-ошибка "Если в ангаре уже заняты все места"
    /// </summary>
    public class ParkingOverflowException : Exception
    {
        public ParkingOverflowException() : base("В ангаре нет свободных мест")
        { }
    }
}
