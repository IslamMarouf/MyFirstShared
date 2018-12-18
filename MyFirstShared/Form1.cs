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

        // this button will close 
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        // this button will display a text box.
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is for test porpuse!");
            
        }

        // this button will show a new form
        private void button3_Click(object sender, EventArgs e)
        {
            SecondForm sform = new SecondForm();
            sform.ShowDialog();
        }
    }
}
