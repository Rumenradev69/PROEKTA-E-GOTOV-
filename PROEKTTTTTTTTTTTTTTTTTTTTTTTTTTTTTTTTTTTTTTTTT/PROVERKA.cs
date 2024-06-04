using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROEKTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT
{
    public partial class PROVERKA : UserControl
    {
        public PROVERKA()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "123456789")
            {
                MessageBox.Show("dobre doshul");
            }
            else
            {
                MessageBox.Show("ne si dobre doshul");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "Alex")
            {
                MessageBox.Show("dobre doshul","asd", MessageBoxButtons.OK,MessageBoxIcon.Information, MessageBoxDefaultButton.Button2 );
                
                label3.Text = "zdravei, " + textBox2.Text + "!";
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
