﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtwieraczLinkow
{
    class Program
    {
        static void Main(string[] args)
        {
            TxtReader useful=TxtReader.ReadTxt();
            useful.SaveLocalisation();
        }
    }
}
