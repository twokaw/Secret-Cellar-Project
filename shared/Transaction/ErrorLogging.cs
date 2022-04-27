using System;
using System.IO;

namespace Shared
{
    public class ErrorLogging
    {
        private static string path;

        public static string Path { get => path; set => path = value; }
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

            s1.WriteLine($"Title: {title}");
            s1.WriteLine($"Message: {msg}");
            s1.WriteLine($"StackTrace: {stkTrace}");
            s1.WriteLine($"Date/Time: {DateTime.Now}");
            s1.WriteLine("===========================================================================================");
            s1.Close();
            fs1.Close();
        }
        public static void WriteToErrorLog(Exception ex, string title)
        {
            WriteToErrorLog(ex.Message, ex.StackTrace, title);
        }
        public static void WriteToErrorLog(Exception ex)
        {
            WriteToErrorLog(ex.Message, ex.StackTrace, ex.Source);
        }
    }
}
