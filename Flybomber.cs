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
    public class Flybomber : Airplane
    {   /// <summary>
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
        /// <param name="weight">Вес бомбардировщика</param>
        /// <param name="mainColor">Основной цвет фюзеляжа</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="bomb">Признак наличия бомб</param>
        public Flybomber(int maxSpeed, float weight, Color mainColor, Color dopColor, bool bomb) :
        base(maxSpeed, weight, mainColor)
        {
            DopColor = dopColor;
            Bomb = bomb;

        }
        public Flybomber(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 5)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Bomb = Convert.ToBoolean(strs[4]);
            }
        }
        /// <summary>
        /// Отрисовка самолета
        /// </summary>
        /// <param name="g"></param>
        public override void DrawBomber(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            // отрисуем сперва бомбы (чтобы потом отрисовка самолета на него "легла")
            if (Bomb)
            {
                g.DrawEllipse(pen, _startPosX + 30, _startPosY - 8, 24, 5);
                g.DrawEllipse(pen, _startPosX + 30, _startPosY + 20, 24, 5);
                Brush bomb = new SolidBrush(DopColor);
                g.FillEllipse(bomb, _startPosX + 30, _startPosY - 8, 24, 5);
                g.FillEllipse(bomb, _startPosX + 30, _startPosY + 20, 24, 5);

            }
            base.DrawBomber(g);
        }

        /// Смена дополнительного цвета
        /// </summary>
        /// <param name="color"></param>
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }
        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name + ";" + Bomb;
        }
    }
}