using System;
using StringMutator.Extension;

namespace StringMutator.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            string welcome = "Welcome\nto\nthe\nString\nMutator.";

            var wordArray = welcome.Lines();

            Console.WriteLine(wordArray.Length);

            foreach(var word in welcome.Lines())
            {
                Console.WriteLine(word);
            }

        }
    }
}
