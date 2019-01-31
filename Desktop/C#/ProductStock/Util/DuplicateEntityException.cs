namespace Util
{
    public class DuplicateEntityException : System.Exception
    {
        public int Code { get; set; }

        public DuplicateEntityException(int code)
        {
            Code = code;
        }
    }
}
