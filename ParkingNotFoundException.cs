using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsBombers
{
    /// <summary>
    /// Класс-ошибка "Если не найден самолет по определенному месту"
    /// </summary>
    public class ParkingNotFoundException : Exception
    {
        public ParkingNotFoundException(int i) : base("Не найден самолет по месту " + i)
        { }
    }
}
