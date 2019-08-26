using System;
using System.Text;
using MalwareScan;
using MalwareScan.AMSI;

namespace AMSISample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var virus = Encoding.UTF8.GetBytes(
                "X5O!P%@AP[4\\PZX54(P^)7CC)7}$EICAR-STANDARD-ANTIVIRUS-TEST-FILE!$H+H*");

            using (var scanner = new MalwareScanner())
            {
                var selfTest = scanner.TestIfItIsWorking();
                var result = scanner.HasVirus(virus, nameof(virus));
                //// ToDo: log positive scan result or selfTest.IsItWorking != true
            }
        }
    }
}
