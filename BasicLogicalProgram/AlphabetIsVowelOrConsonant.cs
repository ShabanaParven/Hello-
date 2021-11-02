using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogicalProgram
{
    public class AlphabetIsVowelOrConsonant
    {
        public void vowelOrConsonant()
        {
            char character;
            Console.WriteLine("enter an alphabet: ");
            character = char.Parse(Console.ReadLine());
            if ((character >= 'A' && character <= 'z') || character >='a' && character<= 'z')
            {
                if (character == 'a' || character == 'A' || character == 'e' || character == 'E' || character == 'i' || character == 'I' || character == 'o' || character == 'O' || character == 'u' || character == 'U')
                {
                    Console.WriteLine(character + "is a vowel");
                }
                else
                {
                    Console.WriteLine(character + "is a consonant");
                }
            }
            else
            {
                Console.WriteLine(character + "is not a alphabet");
            }
            Console.ReadKey();
        }
    }
}
