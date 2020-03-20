using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Common;
using Model.Red;

namespace BatailleNavale
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new RedFactory();
            Console.WriteLine(factory.CreateUsine());


            Console.ReadLine();
        }
        
    }
}
