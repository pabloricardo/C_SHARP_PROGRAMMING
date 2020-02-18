using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
    static class StringExtensions
    {
        public static string Cut(this string thisObj, int index)
        {
            if(thisObj.Length <= index)
            {
                return thisObj;
            }
            else
            {
                return thisObj.Substring(0, index) + "...";
            }
        }
    }
}
