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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Надо ответить на вопрос !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button2.Enabled = false;
            }
            else
                    if (checkedListBox1.SelectedIndex == 2|| checkedListBox1.SelectedIndex == 3)
            {
                checkedListBox1.Items.Clear();
                MessageBox.Show("Вы ответили праивильно !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataBank.Result += 1;
                DataBank.Question5 = true;
                button2.Enabled = true;
            }
            else
            {
                MessageBox.Show("Вы ответили неправильно !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkedListBox1.Items.Clear();
                DataBank.Question5 = false ;
                button2.Enabled = true;
            }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            this.Hide();
            f7.Show();
            
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }
    }
    }

