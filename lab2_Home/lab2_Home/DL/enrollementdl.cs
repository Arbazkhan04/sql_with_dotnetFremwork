using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_Home
{
    public class enrollementdl
    {
        public static void enroll(enrollement enroll)
        {
            MessageBox.Show(enroll.studentRegNo + " " + enroll.courseName);
            if(studentDl.studentExist(enroll.studentRegNo) && courseExist(enroll.courseName))
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("INSERT INTO Enrollement (registrationNumber,courseName) VALUES (@regNumber, @name)", con);
                cmd.Parameters.AddWithValue("@regNumber", enroll.studentRegNo);
                cmd.Parameters.AddWithValue("@name", enroll.courseName);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Enrollement Successfully done");
            }
            else
            {
                MessageBox.Show("Enrollement is failed");
            }
        }
        public static bool courseExist(string name)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM course WHERE name = @name", con);
            cmd.Parameters.AddWithValue("@name", name);

            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }
    }
}
