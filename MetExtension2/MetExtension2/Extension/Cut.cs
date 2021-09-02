

namespace MetExtension2.Extension
{
    static class Cut
    {
        public static string CutString(this string thisObj, int count)
        {
            if(thisObj.Length<= count)
            {
                return thisObj;
            }
            else
            {
                return thisObj.Substring(0, count) + "...";
            }
        }
    }
}
