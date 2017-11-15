using System;
using HelloWorld.Common;

namespace HelloWorld.NoDatabase
{
    public class MemoryHelloProvider : IHelloProvider
    {
        string _message = "Hello World";
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }
    }
}
