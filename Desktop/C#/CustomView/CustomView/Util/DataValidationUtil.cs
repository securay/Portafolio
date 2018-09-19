namespace Util
{
    public static class DataValidationUtil
    {
        public static bool AssertEqual(object o1, object o2)
        {
            return o1.Equals(o2);
        }

        public static bool AssertNotZeroString(string text)
        {
            return !(text.Length == 0);
        }

        public static bool AssertNotNull(object o)
        {
            return o != null;
        }

        public static bool AssertNotZeroValue(long v)
        {
            return v != 0;
        }

        public static bool AssertNotZeroValue(double v)
        {
            return v != 0;
        }

        public static bool AssertNotZeroValue(decimal v)
        {
            return v != 0;
        }
    }
}
