using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    class Person
    {
        private string name;
        private string address;

        public Person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }

        public string Name
        {
            get
            {
                return name;
            }

         
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }

}

        public override string ToString()
        {
            return "Person "+"name="+name+", "+"address=" + address;
        }






    }
}
