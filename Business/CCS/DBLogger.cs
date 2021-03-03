using System;

namespace Business.CCS
{
    public class DBLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Veri tabanına loglandı.");
        }
    }
}