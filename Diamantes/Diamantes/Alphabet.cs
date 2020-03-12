using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public int getLenght()
        {
            return alphabet.Count();
        }

        public bool validate(string letter)
        {
            if (letter.Trim().Equals(""))
            {
                MessageBox.Show("Primeiro informe a letra.");
                return false;
            }
            if (letter.Trim().Count() > 1)
            {
                MessageBox.Show("Informe somente uma letra");
                return false;
            }
            char c = letter.FirstOrDefault();

            if (c> 'Z' || c < 'A')
            {
                MessageBox.Show("Somentes letras são aceitas (A a Z).");
                return false;
            }
            return true;
            //string Str = txtLetter.Text.Trim();
            //double Num;
            //bool isNum = double.TryParse(Str, out Num);

            //if (isNum)
            //        return false;
            //else
            //        return true;
           
        }
    }
}
