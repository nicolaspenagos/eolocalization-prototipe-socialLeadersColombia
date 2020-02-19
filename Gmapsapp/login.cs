using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gmapsapp
{
    public partial class login : UserControl
    {
        public login()
        {
            InitializeComponent();
            textBox1.PasswordChar = '*';
            label1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendToBack();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SendToBack();
        }

        private void pictureBox2_Click(object sender, EventArgs e)

        {
          
            
            if (String.Compare(textBox1.Text, "12345678")==0  )
            {
              
                if (String.Compare(textBox2.Text, "FuraColombia") == 0)
                {
                   
                    SendToBack();
                    label1.Visible = false;
                }
                else {
                    textBox2.Clear();
                    textBox1.Clear();
                    label1.Visible=true;
                }
          
            } else {
                textBox2.Clear();
                textBox1.Clear();
                label1.Visible = true;
            }
            
        }
    }
}
