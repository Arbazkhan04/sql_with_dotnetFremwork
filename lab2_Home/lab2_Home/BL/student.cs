using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace lab2_Home
{
    public class student
    {
       public string registrationNumber;
        public string name;
       public string department;
       public int session;
        public string address;
        public student(string registrationNumber, string name, string department, int session, string address)
        {
            this.registrationNumber = registrationNumber;
            this.name = name;
            this.department = department;
            this.session = session;
            this.address = address;
        }
    }
}
