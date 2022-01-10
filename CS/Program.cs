using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;

namespace RichEditFieldsToValues {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            System.Net.ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12;
            Application.Run(new Form1());
        }
    }
}