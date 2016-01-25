using System;

namespace CoHook.Extentions.IO
{
    [AttributeUsage(AttributeTargets.All)]
    public class EncodingAttribute : Attribute
    {
        public EncodingAttribute(string url)
        {
        }
    }
}