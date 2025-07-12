using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpbasicLearning
{
    class Basic
    {
        public int CustId;
        public string CustName;
        public string CustAddress;
        public Basic(int id, string name, string address)
        {
            CustId = id;
            CustName = name;
            CustAddress = address;
        }
        public void Display()
        {
            Console.WriteLine("Customer ID: " + CustId);
            Console.WriteLine("Customer Name: " + CustName);
            Console.WriteLine("Customer Address: " + CustAddress);
        }
    }
}
