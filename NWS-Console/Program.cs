using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NWS_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\q1.json";

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    char c;

                    while (sr.Peek() >= 0)
                    {
                        c = (char)sr.Read();

                        Console.Write(c);

                        if (c == '}')
                        {
                            Console.WriteLine();

                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
        }
    }
}
