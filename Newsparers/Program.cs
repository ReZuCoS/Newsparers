using System;
using System.Windows.Forms;
using Newsparers.Forms;

namespace Newsparers
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TableAgentsForm());
        }
    }
}
