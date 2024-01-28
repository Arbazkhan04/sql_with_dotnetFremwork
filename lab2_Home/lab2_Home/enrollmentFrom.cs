using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_Home
{
    public partial class enrollmentFrom : Form
    {
        public enrollmentFrom()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void enrollmentFrom_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string regiNumber = textBox1.Text;
            string courseeName = textBox2.Text;
            enrollement enroll = new enrollement(regiNumber, courseeName);
            enrollementdl.enroll(enroll);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new studentForm();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new courseForm();
            form.Show();
            this.Hide();
        }
    }
}
