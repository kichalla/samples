using System;

namespace TestConsoleApp
{
    public class Program
    {
        public void Main(string[] args)
        {
            Console.WriteLine(AppSupportingCoreClr.MyXmlSerializer.GetXml(typeof(Person), new Person() { Name = "James" }));
        }

        public class Person
        {
            public string Name { get; set; }
        }
    }
}
