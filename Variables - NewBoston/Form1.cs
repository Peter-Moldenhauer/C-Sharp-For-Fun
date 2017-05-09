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
            // string variable
            string name = "Peter";
            
            // int variable
            int age = 30;
            
            // bool variable
            bool trueStatement = true;

            // object variable - can set an object equal to anything (bool, string, int)
            object myObj = "I am learning C#.";


            // Substitute in the variables
            // Make sure to do age.ToString() because the MessageBox.Show 
            // wants a string not an int, so you need to turn the int into a string
            MessageBox.Show("My name is " + name + ", I am " + 
                age.ToString() + " years old. This statement is " + trueStatement.ToString() + 
                ". " + myObj.ToString() ); 
        }
    }
}
