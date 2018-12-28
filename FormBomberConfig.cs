using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsBombers
{
    public partial class FormBomberConfig : Form
    {
        /// <summary>
        /// Переменный-выбранный самолет
        /// </summary>
        ITransport bomber = null;

        /// <summary>
        /// Событие
        /// </summary>
        private event bomberDelegate eventAddBomber;

        public FormBomberConfig()
        {
            InitializeComponent();
            panelBlack.MouseDown += panelColor_MouseDown;
            panelGold.MouseDown += panelColor_MouseDown;
            panelGray.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        /// <summary>
        /// Отрисовать самолет
        /// </summary>
        private void DrawBomber()
        {
            if (bomber != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxBomber.Width, pictureBoxBomber.Height);
                Graphics gr = Graphics.FromImage(bmp);
                bomber.SetPosition(10, 50, pictureBoxBomber.Width, pictureBoxBomber.Height);
                bomber.DrawBomber(gr);
                pictureBoxBomber.Image = bmp;
            }
        }

        /// <summary>
        /// Добавление события
        /// </summary>
        /// <param name="ev"></param>
        public void AddEvent(bomberDelegate ev)
        {
            if (eventAddBomber == null)
            {
                eventAddBomber = new bomberDelegate(ev);
            }
            else
            {
                eventAddBomber += ev;
            }
        }

        /// <summary>
        /// Передаем информацию при нажатии на Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelPlain_MouseDown(object sender, MouseEventArgs e)
        {
            labelPlain.DoDragDrop(labelPlain.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        /// <summary>
        /// Передаем информацию при нажатии на Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelbomber_MouseDown(object sender, MouseEventArgs e)
        {
            labelbomber.DoDragDrop(labelbomber.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelPlain_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        /// <summary>
        /// Действия при приеме перетаскиваемой информации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelPlain_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Самолет":
                    bomber = new Airplane(100, 700, Color.White);
                    break;
                case "Бомбардировщик":
                    bomber = new Flybomber(100, 700, Color.White, Color.Black, true);
                    break;
            }
            DrawBomber();
        }

        /// <summary>
        /// Отправляем цвет с панели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        /// <summary>
        /// Принимаем основной цвет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelColor_DragDrop(object sender, DragEventArgs e)
        {
            if (bomber != null)
            {
                bomber.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawBomber();
            }
        }

        /// <summary>
        /// Принимаем дополнительный цвет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labeldopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (bomber != null)
            {
                if (bomber is Flybomber)
                {
                    (bomber as Flybomber).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawBomber();
                }
            }
        }

        /// <summary>
        /// Добавление самолета
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOk_Click(object sender, EventArgs e)
        {
            eventAddBomber?.Invoke(bomber);
            Close();
        }
    }
}

