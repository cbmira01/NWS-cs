using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;

namespace NWS_Console
{
    class Program
    {
        //
        // This project was used to help with:
        //      - exploration and cleanup of the Jeopardy database 
        //        https://www.reddit.com/r/datasets/comments/1uyd0t/200000_jeopardy_questions_in_a_json_file/
        //      - learning how to set up and use the NewtonSoft JSON library
        //      - providing a location for processed Jeopardy records
        //
        // The Jeopardy file is a array of objects, each object describing a particular
        // historical Jeopardy question, its category, answer, and show date. See the
        // JeopardyRecord class for the complete model.
        static void Main(string[] args)
        {
            ConvertRawToLineFormat();            
            UnserializeJson();
        }

        // Demonstrate proper use of NewtonSoft JSON library, and find all fields of
        // the Jeopardy records.
        public static void UnserializeJson()
        {
            string solutionPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string sourceFile = solutionPath + @"\Data\JeopardyDataProcessed.json";

            string[] jsonLines = File.ReadAllLines(sourceFile);
            string jsonLine;
            JeopardyRecord jr;

            Console.WriteLine();
            Console.WriteLine("{0} Jeopardy records found; <CR> to continue.", jsonLines.Length);
            Console.ReadLine();

            for (int i = 0; i < jsonLines.Length; i++)
            {
                jsonLine = jsonLines[i];

                // Let's see all URLs and check any that DO NOT point to j-archive.com
                if (!jsonLine.Contains("http"))
                {
                    continue;
                }

                if (jsonLine.Contains("j-archive.com"))
                {
                    continue;
                }

                jr = JsonConvert.DeserializeObject<JeopardyRecord>(jsonLine);

                // Demonstrate access to all fields.
                Console.WriteLine("Item:        " + i);
                Console.WriteLine("category:    " + jr.category);
                Console.WriteLine("air_date:    " + jr.air_date);
                Console.WriteLine("question:    " + jr.question);
                Console.WriteLine("value:       " + jr.value);
                Console.WriteLine("answer:      " + jr.answer);
                Console.WriteLine("round:       " + jr.round);
                Console.WriteLine("show_number: " + jr.show_number);
                Console.WriteLine();
            }

            Console.ReadLine();
        }


        // Convert the raw Jeopardy records into CRLF-terminated records,
        // and write back to a destination file suitable for use by the 
        // web-app migration/seeding.
        public static void ConvertRawToLineFormat()
        {
            string solutionPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string sourceFile = solutionPath + @"\Data\JeopardyDataRaw.json";
            string destFile = solutionPath + @"\Data\JeopardyDataProcessed.json";

            int count = 0;

            try
            {
                using (StreamReader sr = new StreamReader(sourceFile))
                using (StreamWriter sw = new StreamWriter(destFile))
                {
                    char c;
                    StringBuilder sb = new StringBuilder();

                    while (sr.Peek() >= 0)
                    {
                        // Look for an opening curly-bracket
                        c = (char)sr.Read();
                        if (c != '{')
                            continue;

                        sb.Clear();
                        sb.Append(c);

                        //Now inside JSON curly brackets
                        while (true)
                        {
                            c = (char)sr.Read();
                            sb.Append(c);

                            if (c == '}')
                                break;
                        }

                        // JSON object recognized; store it
                        count++;
                        if (count % 1000 == 0)
                            Console.Write(".");

                        sw.WriteLine(sb.ToString());
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ConvertRawToLineFormat failed: {0}", e.ToString());
            }

        } // end ConvertRawToLineFormat

    }
}

