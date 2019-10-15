using System;

namespace MaxCSharpLibrary
{
    public static class StringLibrary
    {
        /// <summary>
        /// Get the string between "pre" and "post" string at their first occurence
        /// </summary>
        /// <param name="str"></param>
        /// <param name="pre">The starting string</param>
        /// <param name="post">The ending string</param>
        /// <returns>the string between "pre" and "post".
        /// Example:
        /// String: this is a[testing][string].
        /// pre: [
        /// post: ]
        /// return: testing
        /// </returns>
        public static string StringBetweenFirstOccurence(this string str, string pre, string post)
        {
            if (str.IndexOf(pre) < 0)
            {
                throw new Exception("The starting string does not exists.");
            }

            if (str.IndexOf(post) < 0)
            {
                throw new Exception("The ending string does not exists.");
            }

            String splitedString1 = str.Substring(0, str.IndexOf(pre));
            String splitedString2 = str.Substring(str.IndexOf(pre) + pre.Length);

            return splitedString2.Substring(0, splitedString2.IndexOf(post));
        }
    }
}
