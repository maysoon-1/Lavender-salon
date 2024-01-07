using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp16
{
    public partial class Form3 : Form
    {

        public int total = 0;
        int move;
        int movex;
        int movey;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void servicesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void panel8_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movex, MousePosition.Y - movey);
            }
        }

        private void panel8_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            movex = e.X;
            movey = e.Y;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Close();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
           // public int total = 0;
            if ((!checkBox1.Checked) && (!checkBox2.Checked) && (!checkBox3.Checked) && (!checkBox4.Checked) && (!checkBox5.Checked) && (!checkBox6.Checked))
            {
                MessageBox.Show("choose one at least!!");
            }
            else
            {
                if (checkBox1.Checked)
                {
                   if(radioButton1.Checked) total += Convert.ToInt32(label3.Text);
                   if(radioButton2.Checked) total += Convert.ToInt32(label4.Text);
                }
                if (checkBox2.Checked) total += Convert.ToInt32(label6.Text);
                if (checkBox3.Checked) total += Convert.ToInt32(label5.Text);
                if (checkBox4.Checked) total += Convert.ToInt32(label9.Text);
                if (checkBox5.Checked) total += Convert.ToInt32(label11.Text);
                if (checkBox6.Checked) total += Convert.ToInt32(label13.Text);
            }
            MessageBox.Show("the total= " + total);

            Form4 f4 = new Form4();
            f4.Show();
            this.Close();


        }

        private void employeeMangmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            this.Close();
        }

        private void homePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
        }
    }
}
