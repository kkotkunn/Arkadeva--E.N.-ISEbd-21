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
    public partial class FormParking : Form
    {
        /// <summary>
        /// Объект от класса-парковки
        /// </summary>
        Parking<ITransport> parking;

        public FormParking()
        {
            InitializeComponent();
            parking = new Parking<ITransport>(20, pictureBoxParking.Width, pictureBoxParking.Height);
            Draw();
        }

        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxParking.Image = bmp;
        }

        /// <summary>
        /// Обработка нажатия кнопки "Припарковать бомбардировщик"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonbomberpark_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var airplane = new Flybomber(100, 1000, dialog.Color, dialogDop.Color, true);
                    int place = parking + airplane;
                    Draw();
                }
            }
        }

        /// <summary>
        /// Обработка нажатия кнопки "Припарковать самолет"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAirPark_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var airplane = new Airplane(100, 1500, dialog.Color);
                int place = parking + airplane;
                Draw();
            }
        }

        /// <summary>
        /// Обработка нажатия кнопки "Забрать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTake_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "")
            {
                var airplane = parking - Convert.ToInt32(maskedTextBox1.Text);
                if (airplane != null)
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakeFly.Width, pictureBoxTakeFly.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    airplane.SetPosition(10, 40, pictureBoxTakeFly.Width, pictureBoxTakeFly.Height);
                    airplane.DrawBomber(gr);
                    pictureBoxTakeFly.Image = bmp;
                }
                else
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakeFly.Width, pictureBoxTakeFly.Height);
                    pictureBoxTakeFly.Image = bmp;
                }
                Draw();
            }
        }
    }
}

