using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp16
{
    public partial class Form5 : Form
    {
        int id;
        public Form5()
        {
            InitializeComponent();
        }
        public void ShowData()
        {
            string sql = "select * from service";
            DataTable stable = dataaccess.GetDataTable(sql);
            dataGridView1.DataSource = stable;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            ShowData();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int sid = Convert.ToInt32(textBox1.Text); //id
            string sname = textBox2.Text; //name
            int ssalary = Convert.ToInt32(textBox3.Text); //price
            string sphone = textBox4.Text; //agnt

            string sql = "INSERT into service VALUES (" + sid + ", '" + sname + " '," + ssalary + ", '" + sphone + "')";
            int rows = dataaccess.InsertUpdateDelete(sql);
            if (rows != 0)
            {
                MessageBox.Show("Insert successfully");
                textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear();
                ShowData();
            }
            else { MessageBox.Show("Erorr"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sid = Convert.ToInt32(textBox1.Text); //id
            string sname = textBox2.Text; //name
            int ssalary = Convert.ToInt32(textBox3.Text); //price
            string sphone = textBox4.Text; //agnt

            string sql = "UPDATE service SET ser_id=" + sid + ", ser_name= '" + sname + "',ser_price=" + ssalary + ", ser_agent= '" + sphone + "'WHERE ser_id=" + id;
            int rows = dataaccess.InsertUpdateDelete(sql);
            if (rows != 0)
            {
                MessageBox.Show("Update successfully");
                textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear();
                ShowData();
            }
            else { MessageBox.Show("Erorr"); }

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            id = Convert.ToInt32(textBox1.Text);
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sid = Convert.ToInt32(textBox1.Text); //id
            string sql = "DELETE FROM service WHERE ser_id=" + sid;
            int rows = dataaccess.InsertUpdateDelete(sql);
            if (rows != 0)
            {
                MessageBox.Show("Delete successfully");
                textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear();
                ShowData();
            }
            else { MessageBox.Show("Erorr"); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
        }
    }
}
