using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class SMSLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("SMS loglandı.");
        }
    }
}
