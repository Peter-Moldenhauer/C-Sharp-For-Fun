using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_C_Sharp_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // when button is clicked, this message box will appear
            MessageBox.Show("Hello World", "Title on message box");
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            // when mouse hovers over button, this message box will show
            MessageBox.Show("You are hovering your mouse over the button");
        }
    }
}
