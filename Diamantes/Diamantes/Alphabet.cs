using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamonds
{
    public class Alphabet
    {
        List<String> alphabet;

        public Alphabet()
        {
            iniciarLista();
        }

        public void iniciarLista()
        {
            alphabet = new List<string>();

            for (char letter = 'A'; letter <= 'Z'; letter++)
            {
                alphabet.Add(letter.ToString());
            }

        }

        public int getPositionLetter(string letter)
        {
            return alphabet.IndexOf(letter);
        }

        public string getLetter(int position)
        {
            return alphabet[position];
        }
    }
}
