using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day12
{
    public partial class Form1 : Form
    {
        Words word = new Words();
        String[] List = PA4.Properties.Resources.WordList.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
        public Form1()
        {
            InitializeComponent();

            // Additional initialization
            lbWords.Sorted = true;
            lbWordSearch.Sorted = true;
        }

        private bool findText(string text_str)
        {
            bool found = false;

            foreach (object lbItem in lbWords.Items)
            {
                if (lbItem.ToString().StartsWith(text_str, StringComparison.CurrentCultureIgnoreCase))
                {
                    lbWords.SelectedIndex = lbWords.Items.IndexOf(lbItem);
                    found = true;
                    break;
                }
            }

            return found;
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            Console.WriteLine("btnFill_Click");

            #region The Old Way
#if false
            string s;
            FileStream fs;

            try
            {
                fs = new FileStream(@"..\..\WordList.txt", FileMode.Open, FileAccess.Read);
            }
            catch
            {
                MessageBox.Show("Unable to open WordList.txt");
                return;
            }

            StreamReader sr = new StreamReader(fs);

            lbWords.BeginUpdate();
            lbWords.Items.Clear();
            while ((s = sr.ReadLine()) != null)
            {
                lbWords.Items.Add(s);
            }
            lbWords.EndUpdate();
#endif
            #endregion

            lbWords.BeginUpdate();
            lbWords.Items.Clear();
            foreach (string lines in List)
                lbWords.Items.Add(lines);
            lbWords.EndUpdate();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Console.WriteLine("btnClear_Click");
            lbWords.Items.Clear();
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine("txtUser_KeyPress '{0}'", e.KeyChar);

            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                if (!findText(txtUser.Text))
                    lbWords.Items.Add(txtUser.Text);
                else
                {
                    string msgStr = String.Format("String '{0}' already exists!", txtUser.Text);
                    MessageBox.Show(msgStr);
                }
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            bool found = false;

            Console.WriteLine("btnFind_Click");

            found = findText(txtUser.Text);
            if (!found)
            {
                string msgStr = String.Format("Couldn't find the string '{0}'", txtUser.Text);
                MessageBox.Show(msgStr);
            }
        }

        private void lbWords_DoubleClick(object sender, EventArgs e)
        {
            txtUser.Text = lbWords.Text;
        }

        private void btnClear2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("btnClear2_Click");
            lbWordSearch.Items.Clear();
        }

        private void btnFill2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("btnFill2_Click");

            if (rbRhyme.Checked)
            {
                lbWordSearch.BeginUpdate();
                lbWordSearch.Items.Clear();
                foreach (string line in List)
                {
                    if (line.EndsWith(txtUser.Text))
                    {
                        lbWordSearch.Items.Add(line);
                    }
                }
                lbWordSearch.EndUpdate();
            }
            else if (rbScrabble.Checked)
            {
                lbWordSearch.BeginUpdate();
                lbWordSearch.Items.Clear();
                List<string> wordScrabble = word.ScrabbleWord(txtUser.Text);
                foreach (string scrabble in wordScrabble)
                {
                    if (scrabble != wordScrabble[0])
                        lbWordSearch.Items.Add(scrabble);
                }
                lbWordSearch.EndUpdate();
            }
            else if (rbMorphWord.Checked)
            {
                lbWordSearch.BeginUpdate();
                lbWordSearch.Items.Clear();
                string[] wordMorph = word.MorphWord(txtUser.Text);
                foreach (string morph in wordMorph)
                {
                        lbWordSearch.Items.Add(morph);
                }
                lbWordSearch.EndUpdate();
            }
            else if (rbMorphChain.Checked)
            {
                lbWordSearch.BeginUpdate();
                lbWordSearch.Items.Clear();
                int maxLength = Int32.Parse(tbMax.Text);
                List<string> wordChain = word.MorphChain(txtUser.Text, tbEnd.Text, maxLength);
                foreach (string chain in wordChain)
                {
                    lbWordSearch.Sorted = false;
                    lbWordSearch.Items.Add(chain);
                }
                lbWordSearch.EndUpdate();
            }
        }
    }
}
