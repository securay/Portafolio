using System;

namespace Util
{
    public static class Logger
    {
        private static readonly log4net.ILog logger = 
            log4net.LogManager.GetLogger(
                System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static void Info(string log)
        {
            logger.Info(log);
        }

        public static void Warning(string log)
        {
            logger.Warn(log);
        }

        public static void Warning(string log, Exception ex)
        {
            logger.Warn(log, ex);
        }

        public static void Error(string log)
        {
            logger.Error(log);
        }

        public static void Error(string log, Exception ex)
        {
            logger.Error(log, ex);
        }
    }
}
