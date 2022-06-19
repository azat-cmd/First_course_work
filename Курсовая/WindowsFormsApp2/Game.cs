using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Game_form : Form
    {
        public Game_form()
        {
            InitializeComponent();
            Chronos.Start();
            init();
            
        }
        public void game_over(bool is_game)
        {
            if (!is_game)
                Chronos.Stop();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // Функции для подчета координат точки между координатами мыши и центра и при этом на определенном расстоянии от центра
        static double coord_X(int mouse_coord_X, int mouse_coord_Y, int centre_coord_X, int centre_coord_Y, int len)
        {
            int a = centre_coord_X - mouse_coord_X;
            int b = centre_coord_Y - mouse_coord_Y;
            return Math.Abs(centre_coord_X - (a / Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2))) * len);
        }
        static double coord_Y(int mouse_coord_X, int mouse_coord_Y, int centre_coord_X, int centre_coord_Y, int len)
        {
            int a = centre_coord_X - mouse_coord_X;
            int b = centre_coord_Y - mouse_coord_Y;
            return Math.Abs(centre_coord_Y - (b / Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2))) * len);
        }
        //
        double time_min = 1;
        double time_sec;
        int n = 5;
        Final_form final;
        Ball[] balls;
        List<Cannonball> cannon = new List<Cannonball>();
        Graphics g;


        public void time_on()
        {
            Chronos.Start();
        }
        private void time_off()
        {
            Chronos.Stop();
        }
        // Создаем шарики
        private void init()
        {
            time_sec = time_min * 60;
            //Random r = new Random();
            balls = new Ball[n];
            Random rnd = new Random();
            for (int i = 0; i < balls.Length; i++)
            {
                balls[i] = new Ball(panel1);
            }
            // Создаем инструмент для очищения поля
            g = panel1.CreateGraphics();
            //
        }
        //

        // Функция движения шариков
        private void tr()
        {
            // Двигаем каждый шарик
            for (int i = 0; i < balls.Length; i++)
            {
                balls[i].traffic();
            }
            //

            // Цикл для движения пушечных ядер
            for (int i = 0; i < cannon.Count; i++)
            {
                cannon[i].traffic();
                if (cannon[i].x < -100 || cannon[i].x > panel1.Width + 100 || cannon[i].y < -100 || cannon[i].y > panel1.Height + 100)
                    cannon.RemoveAt(i);
            }
            //

            // Циклы для проверки расстояния между шариками. Если сумма квадратов разности координат меньше суммы радиусов, шарики отскакивают путем отрицания скорости каждого из них
            for (int i = 0; i < balls.Length - 1; i++)
            {
                for (int j = i + 1; j < balls.Length; j++)
                {
                    double dist = Math.Pow(balls[j].x - balls[i].x, 2) + Math.Pow(balls[j].y - balls[i].y, 2);
                    double max_dist = balls[j].rad + balls[i].rad;
                    if (dist <= Math.Pow(max_dist, 2))
                    {
                        balls[j].speed[0] *= -1;
                        balls[j].speed[1] *= -1;
                        balls[i].speed[0] *= -1;
                        balls[i].speed[1] *= -1;
                    }
                }
            }
            //

            // Цикл для проверки расстояния между ядрами и шариками
            for (int i = 0; i < balls.Length; i++)
            {
                for (int j = 0; j < cannon.Count; j++)
                {
                    double dist = Math.Pow(cannon[j].x + cannon[j].rad - balls[i].x - balls[i].rad, 2) + Math.Pow(cannon[j].y + cannon[j].rad - balls[i].y - balls[i].rad, 2);
                    double max_dist = balls[i].rad + cannon[j].rad;
                    if (dist <= Math.Pow(max_dist, 2))
                    {
                        Score.Text = (Convert.ToInt32(Score.Text) + 10).ToString();
                        cannon[j].y = -100;
                        balls[i] = new Ball(panel1);
                    }
                }
            }
            //

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time_sec -= Convert.ToDouble(Chronos.Interval)/1000 ;
            time_label.Text = $"{Convert.ToInt32(time_sec) / 60 }:{Convert.ToInt32(time_sec % 60)}";
            if (time_sec < 0)
            {
                Chronos.Stop();
                final = new Final_form(Convert.ToInt32(Score.Text));
                final.Show();
                this.Hide();
            }
            // Очищаем игровое поле
            g.Clear(Color.White);
            //

            // Создаем переменные для посдчета точек для дула
            int wid = panel1.Width;
            int heig = panel1.Height;
            int rad_cannon = 50;
            var relativePoint = panel1.PointToClient(Cursor.Position);
            int mouse_cursorX = relativePoint.X;
            int mouse_cursorY = relativePoint.Y;
            int dulo_len = 70;
            int dulo_x_rad = Convert.ToInt32(coord_X(mouse_cursorX, mouse_cursorY, wid / 2, heig, rad_cannon));
            int dulo_y_rad = Convert.ToInt32(coord_Y(mouse_cursorX, mouse_cursorY, wid / 2, heig, rad_cannon));
            int dulo_x_len = Convert.ToInt32(coord_X(mouse_cursorX, mouse_cursorY, wid / 2, heig, dulo_len));
            int dulo_y_len = Convert.ToInt32(coord_Y(mouse_cursorX, mouse_cursorY, wid / 2, heig, dulo_len)); ;
            // 

            // Запускаем движение шариков
            tr();
            //

            // Рисуем пушку
            g = panel1.CreateGraphics();
            g.FillEllipse(Brushes.Aqua, wid / 2 - rad_cannon, heig - rad_cannon, rad_cannon * 2, rad_cannon * 2);
            g.DrawEllipse(new Pen(Color.Black), wid / 2 - rad_cannon, heig - rad_cannon, rad_cannon * 2, rad_cannon * 2);
            //

            //Стреляем
            if (is_click)
            {
                is_click = false;
                cannon.Add(new Cannonball(panel1, dulo_x_len - 10, dulo_y_len - 10, (dulo_x_len - dulo_x_rad), (dulo_y_len - dulo_y_rad)));
            }
            //  

            // Рисуем дуло
            g.DrawLine(new Pen(Color.Black), new Point(dulo_x_rad, dulo_y_rad), new Point(dulo_x_len, dulo_y_len));
            //


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        bool is_click;
        private void Mcl(object sender, MouseEventArgs e)
        {
            is_click = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Chronos.Stop();
            Pause_panel.Visible = true;
            Continue_button.Visible = true;
            game_over_button.Visible = true;
            return_to_start_button.Visible = true;

        }

        private void Continue_button_Click(object sender, EventArgs e)
        {
            Chronos.Start();
            Pause_panel.Visible = false;
            Continue_button.Visible = false;
            game_over_button.Visible = false;
            return_to_start_button.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            final = new Final_form(Convert.ToInt32(Score.Text));
            final.Show();
            this.Hide();
        }
        Start_form start;
        private void return_to_start_button_Click(object sender, EventArgs e)
        {
            start = new Start_form();
            start.Show();
            this.Hide();
        }
    }
}
