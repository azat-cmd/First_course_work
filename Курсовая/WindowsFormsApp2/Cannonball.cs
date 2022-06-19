using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class Cannonball
    {
        public int x, y, rad;
        public int[] speed = new int[2];
        Graphics instrument;
        public Cannonball(Control parent, int x, int y, int speed_x, int speed_y)
        {
            
            instrument = parent.CreateGraphics();            
            rad = 10;
            this.x = x ;
            this.y = y ;
            draw(x, y, rad);
            speed[0] = speed_x;
            speed[1] = speed_y;
        }

        private void draw(int x, int y, int rad)
        {
            instrument.FillEllipse(Brushes.Yellow, new Rectangle(x , y , rad * 2, rad * 2));
            instrument.DrawEllipse(new Pen(Color.Black), x, y, rad * 2, rad * 2);
        }

        public void traffic()
        {
            
            x += speed[0];
            y += speed[1];
            draw(x, y, rad);


        }
    }
}
