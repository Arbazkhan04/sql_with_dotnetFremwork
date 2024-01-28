using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_Home
{
    public class coursedl
    {
        public static void addCourse(course course)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("INSERT INTO course (name, code) VALUES (@name,@code)", con);
            cmd.Parameters.AddWithValue("@name",course.name);
            cmd.Parameters.AddWithValue("@code", course.code);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully saved");
        }
        public static bool courseExist(string code)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM course WHERE code = @code", con);
            cmd.Parameters.AddWithValue("@code", code);

            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }
        public static void deletecoursee(string code)
        {
            if (courseExist(code))
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("DELETE FROM course WHERE code = @code", con);
                cmd.Parameters.AddWithValue("@code", code);
                cmd.ExecuteNonQuery();
                MessageBox.Show("course is deleted");
            }
            else
            {
                MessageBox.Show("course does not exist");
            }
        }
    }
}
