using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsBombers
{
    public class Airplane : Vehicle, IComparable<Airplane>, IEquatable<Airplane>
    {
        /// <summary>
        /// Ширина отрисовки самолета
        /// </summary>
        protected const int bomberWidth = 100;
        /// <summary>
        /// Высота отрисовки самолета
        /// </summary>
        protected const int bomberHeight = 60;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес самолета </param>
        /// <param name="mainColor">Основной цвет </param>
        public Airplane(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="info">Информация по объекту</param>
        public Airplane(string info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }
        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - bomberWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 10)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - bomberHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        public override void DrawBomber(Graphics g)
        {
            Pen pen = new Pen(MainColor);
            //границы самолета
            g.DrawEllipse(pen, _startPosX, _startPosY + 3, 70, 13);
            g.DrawEllipse(pen, _startPosX + 35, _startPosY - 15, 12, 50);
            g.DrawEllipse(pen, _startPosX + 10, _startPosY - 6, 8, 30);
            //фюзеляж самолета
            Brush brRed = new SolidBrush(MainColor);
            g.FillEllipse(brRed, _startPosX, _startPosY + 3, 70, 13);
            g.FillEllipse(brRed, _startPosX + 35, _startPosY - 15, 12, 50);
            g.FillEllipse(brRed, _startPosX + 10, _startPosY - 6, 7, 30);
        }
        public override string ToString()
        {
            return MaxSpeed + ";" + Weight + ";" + MainColor.Name;
        }

        /// <summary>
        /// Метод интерфейса IComparable для класса Airplane
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Airplane other)
        {
            if (other == null)
            {
                return 1;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return MaxSpeed.CompareTo(other.MaxSpeed);
            }
            if (Weight != other.Weight)
            {
                return Weight.CompareTo(other.Weight);
            }
            if (MainColor != other.MainColor)
            {
                MainColor.Name.CompareTo(other.MainColor.Name);
            }
            return 0;
        }
        /// <summary>
        /// Метод интерфейса IEquatable для класса Airplane
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Airplane other)
        {
            if (other == null)
            {
                return false;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (MainColor != other.MainColor)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Перегрузка метода от object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Airplane airplaneObj = obj as Airplane;
            if (airplaneObj == null)
            {
                return false;
            }
            else
            {
                return Equals(airplaneObj);
            }
        }
        /// <summary>
        /// Перегрузка метода от object
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
