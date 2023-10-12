using System;
using System.Windows.Forms;

namespace NUnitIntegrateWithJenkinsDummyProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int p1 = Convert.ToInt32(textBox1.Text);
            int p2 = Convert.ToInt32(textBox2.Text);

            int res = Add(p1, p2);
        }

        public int Add(int p1, int p2)
        {
            return p1 + p2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int p1 = Convert.ToInt32(textBox1.Text);
            int p2 = Convert.ToInt32(textBox2.Text);

            int res = Subtract(p1, p2);
        }

        public int Subtract(int p1, int p2)
        {
            return p1 - p2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int p1 = Convert.ToInt32(textBox1.Text);
            int p2 = Convert.ToInt32(textBox2.Text);

            int res = Multiply(p1, p2);
        }

        public int Multiply(int p1, int p2)
        {
            return p1 * p2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int p1 = Convert.ToInt32(textBox1.Text);
            int p2 = Convert.ToInt32(textBox2.Text);

            int res = Divide(p1, p2);
        }

        public int Divide(int p1, int p2)
        {
            return p1 / p2;
        }
    }
}
