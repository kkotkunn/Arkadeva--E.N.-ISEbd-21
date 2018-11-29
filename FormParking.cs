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
        /// Объект от класса многоуровневой парковки
        /// </summary>
        MultiLevelParking parking;
        /// <summary>
        /// Форма для добавления
        /// </summary>
        FormBomberConfig form;
        /// <summary>
        /// Количество уровней-парковок
        /// </summary>
        private const int countLevel = 5;
        public FormParking()
        {
            InitializeComponent();
            parking = new MultiLevelParking(countLevel, pictureBoxParking.Width, pictureBoxParking.Height);
            //заполнение listBox
            for (int i = 0; i < countLevel; i++)
            {
                listBoxLevels.Items.Add("Уровень " + (i + 1));
            }
            listBoxLevels.SelectedIndex = 0;
        }

        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        private void Draw()
        {
            if (listBoxLevels.SelectedIndex > -1)
            {//если выбран один из пуктов в listBox (при старте программы ни один пункт не будет выбран и может возникнуть ошибка, если мы попытаемся обратиться к элементу listBox)
                Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parking[listBoxLevels.SelectedIndex].Draw(gr);
                pictureBoxParking.Image = bmp;
            }
        }

        /// <summary>
        /// Обработка нажатия кнопки "Забрать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTake_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                if (maskedTextBox1.Text != "")
                {
                    var bbomber = parking[listBoxLevels.SelectedIndex] - Convert.ToInt32(maskedTextBox1.Text);
                    if (bbomber != null)
                    {
                        Bitmap bmp = new Bitmap(pictureBoxTakeFly.Width,
                        pictureBoxTakeFly.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        bbomber.SetPosition(5, 40, pictureBoxTakeFly.Width, pictureBoxTakeFly.Height);
                        bbomber.DrawBomber(gr);
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

        /// <summary>
        /// Метод обработки выбора элемента на listBoxLevels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
       
        /// <summary>
        /// Метод добавления самолета
        /// </summary>
        /// <param name="car"></param>
        private void AddBomber(ITransport bomber)
        {
            if (bomber != null && listBoxLevels.SelectedIndex > -1)
            {
                int place = parking[listBoxLevels.SelectedIndex] + bomber;
                if (place > -1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Самолет не удалось поставить");
                }
            }

        }

        private void buttonSetBomber_Click_1(object sender, EventArgs e)
        {
            form = new FormBomberConfig();
            form.AddEvent(AddBomber);
            form.Show();
        }
    }
}
