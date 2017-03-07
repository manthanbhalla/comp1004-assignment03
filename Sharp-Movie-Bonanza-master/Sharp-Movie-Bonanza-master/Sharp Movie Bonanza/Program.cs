using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Sharp movie Bonanza
/// Created by Manthan Bhalla
/// Student # 200331757
/// Created on march 06th 2017
///a simple form that allows the user to order the movie and watch it
/// </summary>
namespace Sharp_Movie_Bonanza
{
    static class Program
    {
        public static String[] movie = new String[3];

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashForm());
        }
    }
}
