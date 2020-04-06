namespace System
{
    public static class StringExtension
    {
        public static string FirsToUpper(this String str) 
        {
            return str.Substring(0, 1).ToUpper() + str.Substring(1);
        }
    }
}
