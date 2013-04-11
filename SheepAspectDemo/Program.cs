using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheepAspectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            new TestClass().Method();
            Console.ReadLine();
        }
    }

    public class TestClass
    {
        public int Method()
        {
            return 1;
        }
    }
}
