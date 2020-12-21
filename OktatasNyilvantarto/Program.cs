﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices;
using static OktatasNyilvantarto.Users;

namespace OktatasNyilvantarto
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string[] superUsers = { "balindattila","nagyfonok" };

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (Users.IsSuperUser(superUsers) == true)
            {
                Application.Run(new Form1());
            }
            else 
            {
                MessageBox.Show("Nem vagy superUser");
            }
        }
    }
}
