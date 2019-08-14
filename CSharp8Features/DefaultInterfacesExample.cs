using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8Features
{
    class DefaultInterfacesExample : IDefaultInterfacesExample
    {
        public void DoSomething(string input)
        {
            Console.WriteLine("Do something from DefaultInterfaceExample");
        }
    }
}
