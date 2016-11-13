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
            Console.WriteLine("Let's process some Jeopardy JSON!");

            ConvertRawToLineFormat();            
            UnserializeJson();
        }

        // Demonstrate proper use of NewtonSoft JSON library, perform a simple search, 
        // and access all fields of the Jeopardy records.
        public static void UnserializeJson()
        {
            string solutionPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string sourceFile = solutionPath + @"\Data\JeopardyDataProcessed.json";

            string[] jsonLines = File.ReadAllLines(sourceFile);
            string jsonLine;
            JeopardyRecord jr;

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("{0} Jeopardy records found; <CR> to continue ", jsonLines.Length);
            Console.ReadLine();

            Console.WriteLine();
            Console.Write("Try searching for a word (eg, Galileo): ");
            string search = Console.ReadLine().ToLower();
            Console.WriteLine();

            for (int i = 0; i < jsonLines.Length; i++)
            {
                jsonLine = jsonLines[i];

                // Let's find all records that match a given string...
                if (!jsonLine.ToLower().Contains(search))
                {
                    continue;
                }

                // Let's find all records containing URLs...
                //if (!jsonLine.ToLower().Contains("http"))
                //{
                //    continue;
                //}

                // ... and find any that DO NOT point to j-archive.com
                //if (jsonLine.ToLower().Contains("j-archive.com"))
                //{
                //    continue;
                //}

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

            Console.Write("<CR> to continue ");
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

            int dotCount = 0;

            Console.WriteLine();
            Console.Write("Now we're chopping the original JSON file into line-oriented format ");

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
                        dotCount++;
                        if (dotCount % 10000 == 0)
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

