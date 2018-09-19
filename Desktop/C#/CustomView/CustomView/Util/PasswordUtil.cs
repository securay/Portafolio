using System;

namespace Util
{
    public class PasswordUtil
    {
        public static String encryptPassword(String pass)
        {
            return SHA1Util.SHA1HashStringForUTF8String(pass);
        }

        public static String generateRandomPassword()
        {
            return Math.Abs(new Random().Next()).ToString();
        }
    }
}
