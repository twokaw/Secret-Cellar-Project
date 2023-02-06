using System;
using System.IO;
using System.Threading;

namespace Shared
{
    public class ErrorLogging
    {
        private static string path;
        private static readonly object locker = new object();
        public static string Path { get => path; set => path = value; }
        public static void WriteToErrorLog(string msg, string stkTrace, string title)
        {
            try
            {

                int waitTime = 20; // wait for 2 seconds
                if (!Directory.Exists(Path + "\\Errors\\"))
                    Directory.CreateDirectory(Path + "\\Errors\\");

                FileInfo file = new FileInfo(Path + "\\Errors\\errlog.txt");
                // prevent multiple threads from entering the file from this application
                lock (locker)
                {

                    // wait for the file to unlock
                    while (IsFileLocked(file) && waitTime > 0)
                    {
                        Thread.Sleep(100);
                        waitTime--;
                    }
                    if (waitTime > 0)
                    {
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
                }
            }
            catch { }
        }

        public static bool IsFileLocked(FileInfo file)
        {
            FileStream stream = null;
            try
            {
                stream = file.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            }
            catch
            {
                //handle the exception your way
                return true;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
            return false;
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
