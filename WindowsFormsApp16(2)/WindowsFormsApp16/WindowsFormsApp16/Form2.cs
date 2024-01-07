using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp16
{
    public partial class Form2 : Form
    {




        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || ((!radioButton1.Checked) && (!radioButton2.Checked)) || (textBox2.Text == "") || (textBox3.Text == "") || (textBox4.Text == ""))
            {
                MessageBox.Show("complet the form .. plz");

            }
            else
            {
                Form3 f3 = new Form3();
                f3.Show();
            }
        }

        private void اHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void servicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Close();
        }

        private void reservationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void billToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Close();
        }

        private void اHomeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {


        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void homePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
        }

        private void emolyeeMangmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            for (int i = 1; i <= 70; i++)
            {
                comboBox1.Items.Add(i);
            }
            comboBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            // comboBox1.SelectedItem = 20;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if ((textBox1.Text == String.Empty) || (!Regex.IsMatch(textBox1.Text, "[A-Za-z]+")))
            {
                MessageBox.Show("please Enter correct Name");
                textBox1.Clear();
                textBox1.Focus();
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if ((textBox2.Text == String.Empty) || (!Regex.IsMatch(textBox2.Text, "05[0-9]{8}")))
            {
                MessageBox.Show("please Enter correct Phone Number");
                textBox2.Clear();
                textBox2.Focus();
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if ((textBox3.Text == String.Empty) || (!Regex.IsMatch(textBox3.Text, "[A-Za-z0-9\\-\\.]+@(([[A-Za-z]+)\\.)+([A-Za-z]+)")))
            {
                MessageBox.Show("please Enter correct Email");
                textBox3.Clear();
                textBox3.Focus();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox4.Text = dateTimePicker1.Value.Date.ToString("d");
            if (dateTimePicker1.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("please enter a valid date");
                textBox4.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.SelectedItem = 20;
            radioButton1.Checked = false;
            radioButton2.Checked = false;

        }
    }
}
