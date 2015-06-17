using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Greeter
{
    public class Program
    {
        public void Main(string[] args)
        {
            var names = string.Join(", ", args);
            if(string.IsNullOrEmpty(names))
            {
                Console.WriteLine("Hello, World!");
            }
            else
            {
                Console.WriteLine("Hello! {0}", names);
            }
        }
    }
}
