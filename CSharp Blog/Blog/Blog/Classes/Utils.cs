using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Classes
{
    public class Utils
    {
        public static string CutArticle(string text, int MaxLength = 500)
        {
            if (text == null || text.Length <= MaxLength)
            {
                return text;
            }
            string cuttedText = text.Substring(0, MaxLength) + "...";
            return cuttedText;
        }
    }
}