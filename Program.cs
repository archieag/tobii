using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ActivatableElements
{
    static class Program
    {
        private static EyeXFramework.Forms.FormsEyeXHost _eyeXHost = new EyeXFramework.Forms.FormsEyeXHost();
        /// <summary>
        /// Gets the singleton EyeX host instance.
        /// </summary>
        public static EyeXFramework.Forms.FormsEyeXHost EyeXHost
        {

            get { return _eyeXHost; }
        }
        [STAThread]
        static void Main()
        {
            _eyeXHost.Start();
            
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            
            _eyeXHost.Dispose(); // always dispose on exit
        }
    }
}
