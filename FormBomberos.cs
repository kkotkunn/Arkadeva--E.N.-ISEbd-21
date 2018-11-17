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
        private ITransport airplane;

        /// <summary>
        /// Конструктор
        /// </summary>
        public FormBomberos()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод отрисовки самолета
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxBombers.Width, pictureBoxBombers.Height);
            Graphics gr = Graphics.FromImage(bmp);
            airplane.DrawBomber(gr);
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
            airplane = new Airplane (rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue);
            airplane.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxBombers.Width, pictureBoxBombers.Height);
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
                    airplane.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    airplane.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    airplane.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    airplane.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
        /// <summary>
        /// Обработка нажатия кнопки "Создать бомбардировщик"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreateBomber_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            airplane = new Flybomber(rnd.Next(100, 250), rnd.Next(1500, 2500), Color.Blue, Color.IndianRed, true);
            airplane.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxBombers.Width, pictureBoxBombers.Height);
            Draw();
        }
    }
}
