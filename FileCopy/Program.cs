using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ASI.ES.SkillUp.FileCopy
{
    /// <summary>
    /// Application to copy a file from user specified location to user specified location(folder).																				
    /// </summary>
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
            Application.Run(new FileCopy());
        }
    }
}
