
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab2_Home
{
    public partial class studentForm : Form
    {
        
        public studentForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string regNumber = textBox1.Text;
            string name =   textBox2.Text;
            string department = textBox3.Text;
            int session = int.Parse(textBox4.Text);
            string address = textBox5.Text;
            student st = new student(regNumber, name, department, session, address);
            studentDl.addStudent(st);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from student", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string text = textBox6.Text;
            bool isExist = studentDl.studentExist(text);
            if (isExist) {
                MessageBox.Show("student Exist");
            }
            else
            {
                MessageBox.Show("Student does not exist");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string texgt = textBox7.Text;
            studentDl.deleteStudent(texgt);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form form = new courseForm();
            this.Hide();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form from = new enrollmentFrom();
            from.Show();
            this.Hide();
        }
    }
}
