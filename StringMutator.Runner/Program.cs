using System;
using StringMutator.Extension;

namespace StringMutator.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            string welcome = "Welcome to the\nString Mutator.";

            var wordArray = welcome.Lines();

            Console.WriteLine(wordArray.Length);

            foreach(var word in welcome.Lines())
            {
                Console.WriteLine(word);
            }

        }
    }
}
