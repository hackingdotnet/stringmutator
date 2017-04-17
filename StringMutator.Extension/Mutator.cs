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

        /// <summary>
        /// Returns a string with the first character Capitalized
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string Capitalize(this string input)
        {
            if (String.IsNullOrEmpty(input))
                throw new ArgumentNullException();
            return input[0].ToString().ToUpper() + input.Substring(1);
        }

        /// <summary>
        /// Returns a String that has every word Capitalized
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string Titleize(this string input)
        {
            if (String.IsNullOrEmpty(input))
                throw new ArgumentNullException();

            var result = input.Split(' ');

            for (int i = 0; i <= result.Length - 1; i++)
            {
                result[i] = Capitalize(result[i]);
            }

            return String.Join(" ", result);
        }

        /// <summary>
        /// Returns a String Array with each word in an index
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string[] Words(this string input)
        {
            if (String.IsNullOrEmpty(input))
                throw new ArgumentNullException();
            return input.Split(' ');
        }

        /// <summary>
        /// Returns a Char Array with each Char in an index
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static char[] Characters(this string input)
        {
            if (String.IsNullOrEmpty(input))
                throw new ArgumentNullException();
            return input.ToCharArray();
        }

        /// <summary>
        /// Return a Chopped String as a String Array
        /// </summary>
        /// <param name="input"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string[] Chop(this string input, int value)
        {
            if (String.IsNullOrEmpty(input))
                throw new ArgumentNullException();

            var inputLength = input.Length;
            var size = inputLength / value;            
            var remainder = inputLength % value;
            var stop = size + 1;

            string[] result = new string[size + remainder];
            var move = 0;

            for (int i = 0; i < size; i++)
            {
                result[i] = input.Substring(move, size);
                move += size;
            }

            if (remainder != 0)
            {
                result[size] = input.Substring(move, remainder);
            }
            
            return result;
        }



    }
}
