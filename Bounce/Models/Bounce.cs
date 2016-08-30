using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bounce.Models
{
    public class Ellipse : IDrawable
    {
        //по умолчанию есть пустой конструктор(конструктор без параметров)
        //но мне нравится иметь свои перегруженные конструкторы, раз уж лучше указывать параметры твоего круга
        public int width, height;
        public Ellipse(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        /// <summary>
        /// три раза нажимаешь / (слэш) перед методом и получаешь <summary> - обычно используется для описания методов, параметров, 
        /// по этому summary можно позже сгенерировать документацию
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="box"></param>
        /// <param name="brush"></param>
        public void Draw(int x, int y, PictureBox box, Brush brush)
        {
            box.Refresh();  //очистка коробки для рисования, подумай, стоит ли это держать внутри этого метода, 
                            //ведь могут быть несколько асинхронных картинок и не всегда нужно очищать
            /*
            pencil - чтобы ты просто понимал, 
            графика - твой карандаш и методы для разных картинок для работы, 
            хотя у GDI+(простейшие библиотеки графики в .NET, которые вы сейчас изучаете) есть отдельные brush и другие системные инструменты отрисовки
             */
            Graphics pencil = box.CreateGraphics();
            pencil.FillEllipse(brush, x, y, width, height);
        }
    }
}
