using System;
using System.IO;
using System.Reflection;

namespace Util
{
    public static class Logger
    {
        public static readonly int INFO = 1;
        public static readonly int WARNING = 2;
        public static readonly int ERROR = 3;

        public static void Log(String Message, int Level)
        {
            String path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Message\Messages");
            switch (Level)
            {
                case 1:
                    path += "Info.txt";
                    break;
                case 2:
                    path += "Warning.txt";
                    break;
                case 3:
                    path += "Error.txt";
                    break;
            }
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(path, true))
            {
                file.WriteLine(DateTime.Now.ToString("MM/dd/yy H:mm:ss") + ">>");
                foreach (string line in Message.Split(new String[] { Environment.NewLine }, StringSplitOptions.None))
                {
                    file.WriteLine(line);
                }
                file.WriteLine("<<");
            }
        }

        public static void Log(System.Exception e, int Level)
        {
            String Message = e.Message + "\n" + e.StackTrace;
            String path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Message\Messages");
            switch (Level)
            {
                case 1:
                    path += "Info.txt";
                    break;
                case 2:
                    path += "Warning.txt";
                    break;
                case 3:
                    path += "Error.txt";
                    break;
            }
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(path, true))
            {
                file.WriteLine(DateTime.Now.ToString("MM/dd/yy H:mm:ss") + ">>");
                foreach (string line in Message.Split(new String[] { Environment.NewLine }, StringSplitOptions.None))
                {
                    file.WriteLine(line);
                }
                file.WriteLine("<<");
            }
        }
    }
}
