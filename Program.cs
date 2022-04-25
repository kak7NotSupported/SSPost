﻿using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using SSTattoo;

namespace SSPost
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [DllImport("kernel32.dll")]
        static extern bool AttachConsole(int dwProcessId);

        private const int ATTACH_PARENT_PROCESS = -1;

        static public DataBase database = new DataBase();

        [STAThread]
        static void Main(string[] args)
        {
            AttachConsole(ATTACH_PARENT_PROCESS);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            

        }
    }
}