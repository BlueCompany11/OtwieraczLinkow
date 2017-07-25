using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtwieraczLinkow
{
    public class TxtReader
    {
        string path { get; set; }
        TxtReader(string p)
        {
            this.path = p;
        }
        public static TxtReader ReadTxt()
        {
            Console.Write("If you want to insert the full path press 1 if just the localisation press 2\t");
            string path="";
            char x;
            do
            {
                x = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (x=='1')
                {
                    Console.WriteLine("Enter the full path");
                    path = Console.ReadLine();
                }
                else if (x=='2')
                {
                    Console.WriteLine("Enter the localisation of the .txt file");
                    path = Console.ReadLine();
                    Console.WriteLine("Enter the name of the file");
                    path += "\\" + Console.ReadLine() + ".txt";
                }
            } while (x!='1'&&x!='2');
            Console.WriteLine(x);
            Console.ReadKey();
            TxtReader reader = new TxtReader(path);
            string[] lines = System.IO.File.ReadAllLines(path);
            //foreach (string line in lines)
            //{
            //    System.Diagnostics.Process.Start("chrome.exe", line);
            //}
            for(int i = 0; i < lines.Length; ++i)
            {
                if (lines[i] == "")
                {
                    break;
                }
                else
                {
                    System.Diagnostics.Process.Start("chrome.exe", lines[i]);
                }
            }
            return reader;
        }
        /// <summary>
        /// Saves used localisation to the used .txt file as the last line.
        /// 
        /// </summary>
        public void SaveLocalisation()
        {
            Console.WriteLine("Do you wish to save complete path of this file?");
            Console.WriteLine("It will be saved in the last line of the file.");
            Console.Write("y/n?");
            char x;
            x=Console.ReadKey().KeyChar;
            if (x.ToString().ToLower() == "y")
            {
                using (System.IO.StreamWriter file =
           new System.IO.StreamWriter(path, true))
                {
                    file.WriteLine();
                    file.WriteLine(path);
                }
            }
            else
            {
                //do nothing
            }
        }
    }
}
