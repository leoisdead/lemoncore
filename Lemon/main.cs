using System;
using System.Diagnostics;
using System.Drawing;
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
                float Result = LemonCore.Libs.math.Lerp(0, 100, 0.5f);
                button1.Text = Result.ToString();
            }
            else if (button1.Text != "Test Lerp")
            {
                button1.Text = "Test Lerp";
            }
        }

        private void main_Load(object sender, EventArgs e)
        {
            int x = (this.ClientSize.Width - 200) / 2;
            int y = (this.ClientSize.Height - 200) / 2;

            Program._img.RenderImage(Properties.Resources.teaser, new Rectangle(x, y, 200, 200));
            this.Paint += (s, pe) => Program._img.Render(pe.Graphics);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //HAD TO LOOK THIS UP idk :C
            //the thing says this will only work on windows
            string url = "https://github.com/leoisdead/lemoncore/tree/Release";
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }
    }
}
