using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_4
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            label2.Text = "Вы набрали  " + Convert.ToString(DataBank.Result) + " из 5";
            if (DataBank.Question1==true)
                label3.Text = "1 Вопрос : правильно ";
            else
                label3.Text = "1 Вопрос : не правильно ";

            if (DataBank.Question2 == true)
                label4.Text = "2 Вопрос : правильно ";
            else
                label4.Text = "2 Вопрос : не правильно ";

            if (DataBank.Question3 == true)
                label5.Text = "3 Вопрос : правильно ";
            else
                label5.Text = "3 Вопрос : не правильно ";

            if (DataBank.Question4 == true)
                label6.Text = "4 Вопрос : правильно ";
            else
                label6.Text = "4 Вопрос : не правильно ";

            if (DataBank.Question5 == true)
                label7.Text = "5 Вопрос : правильно ";
            else
                label7.Text = "5 Вопрос : не правильно ";
        }
    }
}
