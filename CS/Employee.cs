using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichEditFieldsToValues
{
    public class Employee
    {
        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public Employee(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
    }
}
