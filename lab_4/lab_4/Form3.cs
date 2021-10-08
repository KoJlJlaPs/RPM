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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Enabled == false)
                MessageBox.Show("Надо ответить на вопрос !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            if (radioButton1.Checked)
            {
                MessageBox.Show("Вы ответили праивильно !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
                DataBank.Result += 1;
                DataBank.Question2 = true;
                button2.Enabled = true;
            }
            if (radioButton2.Checked)
            {
                MessageBox.Show("Вы ответили неправильно !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
                DataBank.Question2 = false;
                button2.Enabled = true;
            }
            if (radioButton3.Checked)
            {
                MessageBox.Show("Вы ответили неправильно !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
                DataBank.Question2 = false;
                button2.Enabled = true;
            }
            if (radioButton4.Checked)
            {
                MessageBox.Show("Вы ответили неправильно !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
                DataBank.Question2 = false;
                button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
                Form4 f4 = new Form4();
                this.Hide();
                f4.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }
    }
}
