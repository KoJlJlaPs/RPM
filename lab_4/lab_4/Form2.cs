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
   
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            if ((!checkBox1.Checked) && (!checkBox2.Checked) && (!checkBox3.Checked) && (!checkBox4.Checked))
                MessageBox.Show("Надо ответить на вопрос !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                if((checkBox1.Checked)&&(checkBox2.Checked)&&(!checkBox3.Checked)&&(!checkBox4.Checked))
                {
                MessageBox.Show("Вы ответили праивильно !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
               
                DataBank.Result += 1;
                DataBank.Question1 = true;
                button2.Enabled = true;
            }
            else
            {
                MessageBox.Show("Вы ответили неправильно !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                DataBank.Question1 = false;
                button2.Enabled = true;

            }
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();
        }
    }
}
