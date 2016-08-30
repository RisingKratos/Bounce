using Bounce.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bounce
{
    public partial class Form1 : Form
    {
        // если не поймешь, обратись к преподавателю, а не забивай, лучше вообще покажи преподу, наверное расскажет как лучше
        public enum Direction
        {
            Left,
            Right,
            Top,
            Down
        };

        int width, height, x, y;
        Direction direction;
        IDrawable figure;
        public Form1()
        {
            InitializeComponent();
            labelForAlmat.Text = "Almat, learn and make it better," + "\n" + "not worse and at least make " + "\n" + "font = helvetica, if you can!";
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            try
            {
                width = Convert.ToInt32(widthTextBox.Text);
                height = Convert.ToInt32(heightTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("You didn't write numbers");
                Process.GetCurrentProcess().Kill();
            }
            x = 10; //можешь потом сделать x и y управляемыми в текстбоксах, но пока пусть лежат так
            y = 10;
            figure = new Ellipse(width, height);    //интерфейс IDrawable для возможного расширения
            /*
             если вдрунг решишь расширить(добавить другие фигуры), именно интерфейс с принципом "SOLID", а именно "Interface Segregation Principle" поможет
             тебе это сделать быстро и переиспользовать код, для этого также есть понятие "Reflection" (спроси у преподавателя, мощный инструмент в разработке)
             ВСЕГДА ПИШИ ИНТЕРФЕЙСЫ, ДАЖЕ ПРОСТЕЙШИЕ, ЭТО ВАЖНО И НУЖНО, ПОТОМ ПОЙМЕШЬ ЗАЧЕМ(ООП)
             */
            DrawingTimer.Start();
        }

        private void DrawingTimer_Tick(object sender, EventArgs e)
        {
            if (x <= 10)
            {
                direction = Direction.Right;
            }
            else if (x > BounceBox.Width)
            {
                direction = Direction.Left;
            }

            switch (direction)
            {
                case Direction.Right:
                    x+=50;
                    figure.Draw(x, y, BounceBox, Brushes.Red);
                    break;
                case Direction.Left:
                    x-=59;
                    figure.Draw(x, y, BounceBox, Brushes.Red);
                    break;
                case Direction.Down:
                    MessageBox.Show("It is not written yet");
                    break;
                case Direction.Top:
                    MessageBox.Show("It is not written yet");
                    break;
                default:
                    break;
            }
        }
    }
}
