using System;
using System.Drawing;
using System.Text;
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
            diamond.AppendLine();
            rchDiamond.AppendText(diamond.ToString());
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            rchDiamond.Text = "";
            if (alphabet.validate(txtLetter.Text.ToUpper()))
                createDiamond(txtLetter.Text.ToUpper());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLetter.Text = "";
            rchDiamond.Text = "";
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            rchDiamond.Text = "";
            for (int i = 0; i < alphabet.getLenght(); i++)
            {
                createDiamond(alphabet.getLetter(i));
            }
        }
    }

}
