using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lemon
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void Open_About_Screen(object sender, EventArgs e)
        {
            Program.about = new About();
            Program.about.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Test Lerp")
            {
                float Result = LemonCore.Libs.math.lerp(0, 100, 0.5f);
                button1.Text = Result.ToString();
            }
            else if (button1.Text != "Test Lerp")
            {
                button1.Text = "Test Lerp";
            }
        }
    }
}
