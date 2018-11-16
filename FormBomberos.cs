using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsBombers
{

    public partial class FormBomberos : Form
    {
        private Flybomber bomb;
        /// <summary>
        /// Конструктор
        /// </summary>
        public FormBomberos()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Метод отрисовки бомбардировщика
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxBombers.Width, pictureBoxBombers.Height);
            Graphics gr = Graphics.FromImage(bmp);
           bomb.DrawBomber(gr);
            pictureBoxBombers.Image = bmp;
        }
        /// <summary>
        /// Обработка нажатия кнопки "Создать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>    
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            bomb = new Flybomber(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.DimGray, Color.RosyBrown, true);
            bomb.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxBombers.Width, pictureBoxBombers.Height);
            Draw();
        }
        /// <summary>
        /// Обработка нажатия кнопок управления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    bomb.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    bomb.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    bomb.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    bomb.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}
