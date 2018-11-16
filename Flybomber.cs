using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsBombers
{
   
    /// <summary>
    /// Класс отрисовки бомбардировщика
    /// </summary>
    public class Flybomber
    {
        /// <summary>
        /// Левая координата отрисовки бомбардировщика
        /// </summary>
        private float _startPosX;
        /// <summary>
        /// Правая кооридната отрисовки бомбардировщика
        /// </summary>
        private float _startPosY;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int _pictureWidth;
        //Высота окна отрисовки
        private int _pictureHeight;
        /// <summary>
        /// Ширина отрисовки автомобиля
        /// </summary>
        private const int carWidth = 100;
        /// <summary>
        /// Ширина отрисовки бомбардировщика
        /// </summary>
        private const int carHeight = 60;
        /// <summary>
        /// Максимальная скорость бомбардировщика
        /// </summary>
        public int MaxSpeed { private set; get; }
        /// <summary>
        /// Вес бомбардировщика
        /// </summary>
        public float Weight { private set; get; }
        /// <summary>
        /// Основной цвет фюзеляжа
        /// </summary>
        public Color MainColor { private set; get; }
        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { private set; get; }
        /// <summary>
        /// Признак наличия бомб
        /// </summary>
        public bool Bomb { private set; get; }
        
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="bomb">Признак наличия бомб</param>             
        public Flybomber(int maxSpeed, float weight, Color mainColor, Color dopColor, bool bomb)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Bomb = bomb;
            
        }
        /// <summary>
        /// Установка позиции бомбардировщика
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        /// <summary>
        /// Изменение направления пермещения
        /// </summary>
        /// <param name="direction">Направление</param>
        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100/ Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - carWidth)
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
                    if (_startPosY + step < _pictureHeight - carHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        /// <summary>
        /// Отрисовка бомбардировщика
        /// </summary>
        /// <param name="g"></param>
        public void DrawBomber(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            // отрисуем сперва бомбы самолета (чтобы потом отрисовка самолета на него "легла")
            if (Bomb)
            {
                //бомбы
                g.DrawEllipse(pen, _startPosX + 30, _startPosY - 8, 24, 5);
                g.DrawEllipse(pen, _startPosX + 30, _startPosY + 20, 24, 5);

                //бомбы
                Brush brYellow = new SolidBrush(DopColor);
                g.FillEllipse(brYellow, _startPosX + 30, _startPosY - 8, 24, 5);
                g.FillEllipse(brYellow, _startPosX + 30, _startPosY + 20, 24, 5);

            }
     
            //границы самолета
            g.DrawEllipse(pen, _startPosX, _startPosY+3, 70, 13);
            g.DrawEllipse(pen, _startPosX+35, _startPosY-15, 12, 50);
            g.DrawEllipse(pen, _startPosX + 10, _startPosY-6, 8, 30);
          
            //корпус
            Brush brRed = new SolidBrush(MainColor);
            g.FillEllipse(brRed, _startPosX, _startPosY+3, 70, 13);
            g.FillEllipse(brRed, _startPosX + 35, _startPosY - 15, 12, 50);
            g.FillEllipse(brRed, _startPosX + 10, _startPosY - 6, 7, 30);
                                  
        }
    }
}