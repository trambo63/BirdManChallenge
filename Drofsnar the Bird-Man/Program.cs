﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Drofsnar_the_Bird_Man
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProgramIU ui = new ProgramIU();
            ui.Run();
        }
    }
}
