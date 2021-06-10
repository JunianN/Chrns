using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GunaTest
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            ProgBar.Value = startpoint;
            if (ProgBar.Value == 25)
            {
                ProgBar.Value = 0;
                timer1.Stop();
                MainForm mf = new MainForm();
                this.Hide();
                mf.Show();
            }
        }
    }
}