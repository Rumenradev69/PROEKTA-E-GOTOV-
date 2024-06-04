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
    public partial class SPISAK : Form
    {
        public SPISAK()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            listBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> numbers = new List<int>();
            foreach (var item in listBox1.Items)
            {
                numbers.Add(int.Parse(item.ToString()));
            }
            numbers.Sort();

            listBox1.Items.Clear();
            foreach (var number in numbers)
            {
                listBox1.Items.Add(number);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
