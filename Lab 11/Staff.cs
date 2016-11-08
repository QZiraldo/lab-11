using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    class Staff:Person
    {
        private string school;
        private double pay;

        public Staff(string name, string address, string school, double pay) : base(name, address)
        {
            this.school = school;
            this.pay = pay;
        }

        public string School
        {
            get
            {
                return school;
            }

            set
            {
                school = value;
            }
        }

        public double Pay
        {
            get
            {
                return pay;
            }

            set
            {
                pay = value;
            }
        }

        public override string ToString()
        {
            return "Staff " + base.ToString() + ", " + "school=" + school + ", " + "pay=" + pay;
        }



    }
}
