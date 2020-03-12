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
    public partial class frmDiamond : Form
    {
        Alphabet alphabet;
        public frmDiamond()
        {
            InitializeComponent();
            alphabet = new Alphabet();
        }

        private void createDiamond(string letter)
        {
   
            int index = alphabet.getPositionLetter(letter);
            int spaces = index;
            int x = 1;

            StringBuilder diamond = new StringBuilder();

            for (int i = 0; i <= index; i++, spaces--, x += 2)
            {
                if (i == 0) diamond.Append(" ");
                diamond.Append(new string(' ', spaces));

                diamond.Append(alphabet.getLetter(i));

                diamond.Append(new string(' ', x));

                if (i > 0) diamond.Append(alphabet.getLetter(i));

                diamond.AppendLine();
            }
            spaces = 1;
            x = index * 2;
            for (int i = index - 1; i >= 0; i--, spaces++, x -= 2)
            {
                if (i == 0) diamond.Append(" ");
                diamond.Append(new string(' ', spaces));

                diamond.Append(alphabet.getLetter(i));

                if (x <= 0) x = i + 2;
                diamond.Append(new string(' ', x));

                if (i > 0) diamond.Append(alphabet.getLetter(i));

                diamond.AppendLine();
            }
            formatText(diamond.ToString());
        }

        private void formatText(string text)
        {
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.SelectionLength = 0;

            richTextBox1.SelectionColor = Color.Red;
            richTextBox1.AppendText(text);
            richTextBox1.SelectionColor = richTextBox1.ForeColor;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            if (alphabet.validate(txtLetter.Text.ToUpper()))
                createDiamond(txtLetter.Text.ToUpper());
   
        }

        private void txtLetter_Validated(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            if (alphabet.validate(txtLetter.Text.ToUpper()))
                createDiamond(txtLetter.Text.ToUpper());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLetter.Text = "";
            richTextBox1.Text = "";
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            for (int i = 0; i < alphabet.getLenght(); i++)
            {
                createDiamond(alphabet.getLetter(i));
            }
        }
    }

  
}
