using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8Features
{
    interface IDefaultInterfacesExample
    {
        void DoSomething(string input);

        void DoSomethingDifferent(string input)
        {
            Console.WriteLine("Do something diffrent from default interface implementation");
        }
    }
}
