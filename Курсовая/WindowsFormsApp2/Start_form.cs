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
    public partial class Start_form : Form
    {
        Game_form game;
        public Start_form()
        {
            InitializeComponent();
            game = new Game_form();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            game.Show();
            this.Hide();
        }
    }
}
