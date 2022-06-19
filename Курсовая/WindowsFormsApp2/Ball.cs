using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class Ball
    {
        public int x, y, rad, width, height;
        public int[] speed = new int[2];
        static Random rnd = new Random();
        Graphics instrument;
        public Ball(Control parent)
        {
            instrument = parent.CreateGraphics();
            //Узнаем границы для создания шаров
            width = parent.Width;
            height = parent.Height;
            //Создаем радиус шаров
            rad = rnd.Next(30, 40);
            //Создаем координаты для рисования шаров
            x = rnd.Next(10, width - 10 - 2 * rad);
            y = rnd.Next(10, height - 10 - 2 * rad);
            //Рисуем шары
            draw(x, y, rad);
            //Задаем скорость шарам
            speed[0] = rnd.Next(1, 20);
            speed[1] = rnd.Next(1, 20);
           
        }

        // Функция отрисовки по заданным координатам
        private void draw(int x, int y, int rad)
        {
            instrument.FillEllipse(Brushes.Red, new Rectangle(x, y, rad * 2, rad * 2));
            instrument.DrawEllipse(new Pen(Color.Black), x, y, rad * 2, rad * 2);
        }
        // Функция движения
        public void traffic()
        {
            if (x < 0)
            {
                speed[0] *= -1;
                x = 0;
            }

            if (y < 0)
            {
                speed[1] *= -1;
                y = 0;
            }

            if (x + rad * 2 > width)
            {
                speed[0] *= -1;
                x = width - rad * 2;
            }

            if (y + rad * 2 > height)
            {
                speed[1] *= -1;
                y = height - rad * 2;

            }

            x += speed[0];
            y += speed[1];
            draw(x, y, rad);
        }


    }
}
