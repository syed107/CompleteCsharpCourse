using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpbasicLearning
{
    public struct Struct
    {
        public int CustId;
        public string CustName;
        public string CustAddress;
        public Struct(int id, string name, string address)
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
        //struct are value type in C#, i.e their values are stored in stack where as classes are reference type, i.e their values are stored in heap.
    }
}
