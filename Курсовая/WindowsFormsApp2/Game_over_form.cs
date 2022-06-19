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
    public partial class Final_form : Form
    {
        public Final_form(int score)
        {
            InitializeComponent();
            rezult_label.Text = score.ToString();
        }

        private void Final_form_Load(object sender, EventArgs e)
        {

        }
    }
}
