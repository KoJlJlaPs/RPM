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
    public partial class Form5 : Form
    {
        int x = 0;
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((comboBox1.SelectedIndex == -1) || (comboBox2.SelectedIndex == -1 || comboBox3.SelectedIndex == -1))
            { MessageBox.Show("Надо ответить на вопрос !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else
            {
                if ((comboBox1.SelectedIndex == 1) && (comboBox2.SelectedIndex == 0) && (comboBox3.SelectedIndex == 1))
                {
                    MessageBox.Show("Вы ответили правильно !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataBank.Result += 1;
                    DataBank.Question4 = true;
                    button2.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Вы ответили неправильно !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataBank.Question4 = false;
                    button2.Enabled = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
     
                Form6 f6 = new Form6();
                this.Hide();
                f6.Show();
            
           
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }
    }
}
