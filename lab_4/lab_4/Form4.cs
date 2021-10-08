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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string[] itemlist = new string[3];
            itemlist[0] = "Антарктическая пустыня";
            itemlist[1] = "Сахара";
            itemlist[2] = "Чиуауа";
            button2.Enabled = false;   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex==0&&listBox2.Items.Count<1)
            {
                listBox2.Items.Add(listBox1.Text);
                listBox2.Text = Convert.ToString(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(0);
            }
            if(listBox1.SelectedIndex==1 && listBox2.Items.Count < 1)
            {
                listBox2.Items.Add(listBox1.Text);
                listBox2.Text = Convert.ToString(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(1);
            }
            if (listBox1.SelectedIndex == 2 && listBox2.Items.Count < 1)
            {
                listBox2.Items.Add(listBox1.Text);
                listBox2.Text = Convert.ToString(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(2);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0 && listBox3.Items.Count < 1)
            {
                listBox3.Items.Add(listBox1.Text);
                listBox3.Text = Convert.ToString(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(0);
            }
            if (listBox1.SelectedIndex == 1 && listBox3.Items.Count < 1)
            {
                listBox3.Items.Add(listBox1.Text);
                listBox3.Text = Convert.ToString(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(1);
            }
            if (listBox1.SelectedIndex == 2 && listBox3.Items.Count < 1)
            {
                listBox3.Items.Add(listBox1.Text);
                listBox3.Text = Convert.ToString(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(2);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0 && listBox4.Items.Count < 1)
            {
                listBox4.Items.Add(listBox1.Text);
                listBox4.Text = Convert.ToString(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(0);
            }
            if (listBox1.SelectedIndex == 1 && listBox4.Items.Count < 1)
            {
                listBox4.Items.Add(listBox1.Text);
                listBox4.Text = Convert.ToString(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(1);
            }
            if (listBox1.SelectedIndex == 2 && listBox4.Items.Count < 1)
            {
                listBox4.Items.Add(listBox1.Text);
                listBox4.Text = Convert.ToString(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(2);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((listBox2.Text == "") && (listBox3.Text == "") && (listBox4.Text == ""))
            {
                MessageBox.Show("Надо ответить на вопрос!", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
                if ((listBox2.Items[0]== "Антарктическая пустыня") && (listBox3.Items[0] == "Сахара")&& (listBox4.Items[0] == "Чиуауа"))
                {
                MessageBox.Show("Вы ответили правильно !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataBank.Result += 1;
                DataBank.Question3 = true;
                button2.Enabled = true;
            }
            else
            {
                MessageBox.Show("Вы ответили неправильно !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataBank.Question3 = false;
                button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            this.Hide();
            f5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(listBox2.SelectedIndex==0)
            {
                listBox1.Items.Add(listBox2.Text);
                listBox2.Text = Convert.ToString(listBox2.SelectedIndex);
                listBox2.Items.RemoveAt(0);
            }
            if (listBox3.SelectedIndex == 0)
            {
                listBox1.Items.Add(listBox3.Text);
                listBox3.Text = Convert.ToString(listBox3.SelectedIndex);
                listBox3.Items.RemoveAt(0);
            }
            if (listBox4.SelectedIndex == 0)
            {
                listBox1.Items.Add(listBox4.Text);
                listBox4.Text = Convert.ToString(listBox4.SelectedIndex);
                listBox4.Items.RemoveAt(0);
            }

        }
        }
    }


