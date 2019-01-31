using System;

namespace Util
{
    public class PasswordUtil
    {
        public static string encryptPassword(String pass)
        {
            return SHA1Util.SHA1HashStringForUTF8String(pass);
        }

        public static string generateRandomPassword()
        {
            return Math.Abs(new Random().Next()).ToString();
        }
    }
}
