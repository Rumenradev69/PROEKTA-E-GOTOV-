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
    public partial class ADMIN : Form
    {
        public ADMIN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a1 = int.Parse(textBox1.Text);
            int a2 = int.Parse(textBox2.Text);
            int a3 = int.Parse(textBox3.Text);
            int a4 = int.Parse(textBox4.Text);
            int a5 = int.Parse(textBox5.Text);
            int a6 = int.Parse(textBox6.Text);
            if(checkBox1.Checked && radioButton1.Checked)
            {
                label2.Text = $"obshto: {a1}";
            }
            else if (checkBox1.Checked && radioButton2.Checked)
            {
                label2.Text = $"obshto: {a4}";
            }
            else if (checkBox1.Checked && radioButton3.Checked)
            {
                label2.Text = $"obshto: {a1 + a4}";
            }
            else if (checkBox2.Checked && radioButton1.Checked)
            {
                label2.Text = $"obshto: {a2}";
            }
            else if (checkBox2.Checked && radioButton2.Checked)
            {
                label2.Text = $"obshto: {a5}";
            }
            else if (checkBox2.Checked && radioButton3.Checked)
            {
                label2.Text = $"obshto: {a2 + a5}";
            }
            else if (checkBox3.Checked && radioButton1.Checked)
            {
                label2.Text = $"obshto: {a3}";
            }
            else if (checkBox3.Checked && radioButton2.Checked)
            {
                label2.Text = $"obshto: {a6}";
            }
            else if (checkBox3.Checked && radioButton3.Checked)
            {
                label2.Text = $"obshto: {a3 + a6}";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ADMIN_Load(object sender, EventArgs e)
        {

        }
    }
}
