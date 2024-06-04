using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROEKTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT
{
    public partial class VHOD : UserControl
    {
        public VHOD()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Alex" && maskedTextBox1.Text == "0000")
            {
                ADMIN a = new ADMIN();
                this.Hide();
                a.ShowDialog();
            }
            else
                if (textBox1.Text == "xelA" && maskedTextBox1.Text == "0001")
            {
                SPISAK a = new SPISAK();
                this.Hide();
                a.ShowDialog();
            }
            

        }            
    }
}
