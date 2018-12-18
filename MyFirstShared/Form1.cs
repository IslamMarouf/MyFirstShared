using System;
using System.Windows.Forms;

namespace MyFirstShared
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is for test porpuse!");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SecondForm sform = new SecondForm();
            sform.ShowDialog();
        }
    }
}
