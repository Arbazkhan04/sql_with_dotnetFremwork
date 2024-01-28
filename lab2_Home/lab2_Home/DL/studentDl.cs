
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_Home
{
    public class studentDl
    {
     
        public static void addStudent(student st)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("INSERT INTO student (registrationNumber, name, department, session, address) VALUES (@regNumber, @name, @dep, @session, @address)", con);
            cmd.Parameters.AddWithValue("@regNumber", st.registrationNumber);
            cmd.Parameters.AddWithValue("@name", st.name);
            cmd.Parameters.AddWithValue("@dep", st.department);
            cmd.Parameters.AddWithValue("@session", st.session);
            cmd.Parameters.AddWithValue("@address", st.address);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully saved");
        }

        public static bool studentExist(string regNumber)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM student WHERE registrationNumber = @regNumber", con);
            cmd.Parameters.AddWithValue("@regNumber", regNumber);

            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }
        public static void deleteStudent(string regNumber)
        {
            if (studentExist(regNumber))
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("DELETE FROM student WHERE registrationNumber = @regNumber", con);
                cmd.Parameters.AddWithValue("@regNumber", regNumber);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User is deleted");
            }
            else
            {
                MessageBox.Show("User does not exist");
            }
        }

    }
}
