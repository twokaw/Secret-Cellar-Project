using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    class ErrorLogging
    {
        public static string Path{get;set;}
        public static void WriteToErrorLog(string msg, string stkTrace, string title)
        {
            if (!(System.IO.Directory.Exists(Path + "\\Errors\\")))
            {
                System.IO.Directory.CreateDirectory(Path + "\\Errors\\");
            }
            FileStream fs = new FileStream(Path + "\\Errors\\errlog.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter s = new StreamWriter(fs);
            s.Close();
            fs.Close();
            FileStream fs1 = new FileStream(Path + "\\Errors\\errlog.txt", FileMode.Append, FileAccess.Write);
            StreamWriter s1 = new StreamWriter(fs1);

            s1.Write("Title: " + title + "\r\n");
            s1.Write("Message: " + msg + "\r\n");
            s1.Write("StackTrace: " + stkTrace + "\r\n");
            s1.Write("Date/Time: " + DateTime.Now.ToString() + "\r\n");
            s1.Write("===========================================================================================" + "\r\n");
            s1.Close();
            fs1.Close();
        }
    }
}
