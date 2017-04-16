using System;

namespace StringMutator.Extension
{
    public static class Mutator
    {
        /// <summary>
        /// Returns sting input
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string StringExtension(this string input)
        {
            if (String.IsNullOrEmpty(input))
                throw new ArgumentNullException();
            return input;
        }

        /// <summary>
        /// Returns A String Array with each line in an index
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string[] Lines(this string input)
        {
            if (String.IsNullOrEmpty(input))
                throw new ArgumentNullException();
            return input.Split('\n');
        }

    }
}
