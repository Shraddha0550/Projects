﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Camera_House
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Log_In());
        }
    }
}
