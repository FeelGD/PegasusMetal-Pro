using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PegasusMetal_Pro
{
    public static class Utilities
    {
        /*public static string GetExceptionMessages(this Exception e, string msgs = "")
        {
            if (e == null) return string.Empty;
            if (msgs == "")
            {
                msgs = e.Message;
                WriteLog(e.Source, e.Message, ConsoleColor.Red);
            }
            if (e.InnerException != null)
            {
                msgs += "\r\nInnerException: " + GetExceptionMessages(e.InnerException);
                WriteLog(e.Source, e.InnerException.Message, ConsoleColor.Red);
            }
            return msgs;
        }*/

        public static void WriteErrorMessages(this Exception e)
        {
            if (e != null)
            {
                WriteLog(e.Source, e.Message, ConsoleColor.Red);
            }
            if (e.InnerException != null)
            {
                WriteErrorMessages(e.InnerException);
            }
        }

        public static void Minimize()
        {
            foreach(var item in Application.OpenForms)
            {
                ((Form)item).WindowState = FormWindowState.Minimized;
            }
        }

        public static void WriteLog(string LogType, string Log, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine("[{0}][{1}] : {2}", DateTime.Now.ToString("HH:mm:ss"), LogType, Log);
        }

    }
}
