using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    class Employee
    {
        private string empName;

        public string EmpName
        {
            get { return  empName; }
            set { empName = value; }

        }

        public string address;

        public string Address
        {
            get { return address; }
            protected set { address = value; }

        }
        public Employee()
        {
            EmpName = "pooja" ;
            Address = "mahape";
        }
        public Employee(string name, string address)
        {
            this.EmpName = name;
            this.Address = address;
        }

    }
}
