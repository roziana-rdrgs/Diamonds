using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diamonds
{
    public partial class Form1 : Form
    {
        Alphabet alphabet;
        public Form1()
        {
            InitializeComponent();
            alphabet = new Alphabet();
        }


        private void btnGerar_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            string letter = txtLetra.Text;
            int index = alphabet.getPositionLetter(letter.ToUpper());
            int spaces = index;
            int x = 1;

            StringBuilder diamond = new StringBuilder();

            for (int i = 0; i <= index; i++, spaces--, x += 2)
            {
                if (i == 0 ) diamond.Append(" ");
                diamond.Append(new string(' ',spaces));

                diamond.Append(alphabet.getLetter(i));

                diamond.Append(new string(' ', x));

                if (i > 0) diamond.Append(alphabet.getLetter(i));
                
                diamond.AppendLine();
            }
            spaces = 1;
            x = index * 2;
            for (int i = index -1; i >= 0; i--, spaces++, x -= 2)
            {
                if (i == 0) diamond.Append(" ");
                diamond.Append(new string(' ', spaces));

                diamond.Append(alphabet.getLetter(i));

                if (x <= 0) x = i + 2;
                diamond.Append(new string(' ', x));

                if (i > 0) diamond.Append(alphabet.getLetter(i));

                diamond.AppendLine();
            }

            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.SelectionLength = 0;

            richTextBox1.SelectionColor = Color.Red;
            richTextBox1.AppendText(diamond.ToString());
            richTextBox1.SelectionColor = richTextBox1.ForeColor;
        }
    
        private Color FromRgbExample(int i)
        {
            // Create a green color using the FromRgb static method.
            Color myRgbColor = new Color();
            myRgbColor = Color.FromArgb(0, 255, i*10);
            return myRgbColor;
        }

        
    }

  
}
