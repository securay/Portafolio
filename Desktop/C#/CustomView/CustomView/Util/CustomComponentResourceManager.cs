namespace Util
{
    internal class CustomComponentResourceManager : System.ComponentModel.ComponentResourceManager
    {
        public CustomComponentResourceManager(System.Type type, string resourceName)
            : base(type)
        {
            this.BaseNameField = resourceName;
        }
    }
}
