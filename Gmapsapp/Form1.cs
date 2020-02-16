using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Gmapsapp
{
    public partial class Form1 : Form
    {
        private bool mh = false;
        public Form1()
        {
            InitializeComponent();
            panel4.Visible = false;
            userControl21.SendToBack();
            
            second.SendToBack();
        }

        private void userControl12_Load(object sender, EventArgs e)
        {
          

        }

        public void senToBack() {
            login1.SendToBack();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            panel4.BringToFront();
            if (mh)
            {
                panel4.Visible = false;
                mh = false;
            }
            else {
                panel4.Visible = true;
                mh = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl11.BringToFront();
            second.SendToBack();
            panel4.Visible = false;
            mh = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            userControl21.BringToFront();
            panel4.BringToFront();
            panel4.Visible = false;

            panel4.BringToFront();
            mh = false;
            second.BringToFront();
            panel2.BringToFront();
            panel1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
            panel4.Visible = false;
            mh = false;
            panel4.BringToFront();
            panel2.BringToFront();
            panel1.BringToFront();
            login1.BringToFront();

        }

        private void button1_KeyDown(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Space))
            {
                MessageBox.Show("MARIA ANGELA TORRES ESTA SUFRIENDO UN EMERGENCIA Lat: 4.05094603392196 Lon: -73.90967874235682");
            }
        }
    }
}
