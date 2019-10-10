using System;

namespace MaxCSharpLibrary
{
    public static class StringLibrary
    {
        //
        // Summary:
        //     Get the string between "pre" and "post" string at their first occurence
        //
        // Parameters:
        //   pre:
        //     The starting string
        //   post:
        //     The ending string
        //
        // Returns:
        //     the string between "pre" and "post".
        //     Example:
        //       String: this is a [testing] [string].
        //       pre: [
        //       post: ]
        //       return: testing
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

            return str.Substring(str.IndexOf(pre) + pre.Length, str.IndexOf(post) - str.IndexOf(pre));
        }
    }
}
