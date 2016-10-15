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

namespace PA4
{
    /// <summary>
    /// All of the event handlers due to clicks, buttons, and functions.
    /// </summary>
    public partial class Form1 : Form
    {
        Words word = new Words();
        public Form1()
        {
            InitializeComponent();

            // Additional initialization
            lbWords.Sorted = true;
        }

        /// <summary>
        /// Finds the word from the lbWords listbox
        /// </summary>
        /// <param name="text_str"></param>
        /// <returns></returns>
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

        /// <summary>
        /// One click on the top left "Fill" button fills the lbWords listbox with our entire resource "WordList.txt" file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFill_Click(object sender, EventArgs e)
        {
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
            string[] allWords = word.PrintAll();
            foreach (string words in allWords)
                lbWords.Items.Add(words);
            lbWords.EndUpdate();
        }

        /// <summary>
        /// One click on the top left "Clear" button will erase all words in lbWords textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            lbWords.Items.Clear();
        }

        /// <summary>
        /// In the textbox, the user can add a word into the lbWords listbox by typing out the word and pressing the enter key.
        /// If the word is already inside the lbWords listbox, print out a message box that says it already exists.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        /// <summary>
        /// One click on the "Find" button will look for the same word inside the lbWords listbox from the textbox.
        /// If word is not found in lbWords list box, print out a message box that says it cannot be found.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFind_Click(object sender, EventArgs e)
        {
            bool found = false;
            found = findText(txtUser.Text);
            if (!found)
            {
                string msgStr = String.Format("Couldn't find the string {0}", txtUser.Text);
                MessageBox.Show(msgStr);
            }
        }

        /// <summary>
        /// Double clicking on a word from the lbWords listbox will fill in the textbox with the word.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbWords_DoubleClick(object sender, EventArgs e)
        {
            txtUser.Text = lbWords.Text;
        }

        /// <summary>
        /// One click on the right "Clear" button will clear the lbWordSearch listbox on the right. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear2_Click(object sender, EventArgs e)
        {
            lbWordSearch.Items.Clear();
        }

        /// <summary>
        /// One click on the right "Fill" button fills the lbWordSearch listbox with our entire resource "WordList.txt" file.
        /// Depending on what radio button is checked (Rhyme, Scrabble, Morph Word, or Morph Chain), the lbWordSearch list box will be filled with the designated function correlated to the word in the textboxes.
        /// If none of the radio buttons are checked, print out error message box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFill2_Click(object sender, EventArgs e)
        {
            if (!(rbRhyme.Checked || rbScrabble.Checked || rbMorphWord.Checked || rbMorphChain.Checked))
            {
                string msgStr = String.Format("Option not selected.");
                MessageBox.Show(msgStr);
            }

            // Finds words that rhyme with the word inside the textbox.
            // Used try/catch to detect error from user input.
            else if (rbRhyme.Checked)
            {
                lbWordSearch.BeginUpdate();
                lbWordSearch.Items.Clear();
                List<string> rhymeWords = word.RhymeWord(txtUser.Text);
                try
                {
                    if (rhymeWords.Count == 0 || string.IsNullOrWhiteSpace(txtUser.Text))
                    {
                        throw new Exception();
                    }
                    labelError.Visible = false;
                    foreach (string words in rhymeWords)
                    {
                        lbWordSearch.Items.Add(words);
                    }
                }
                catch (Exception)
                {
                    labelError.Text = "Invalid Input";
                    labelError.Visible = true;
                }
                // If no words are found, print out message
                lbWordSearch.EndUpdate();
            }

            // Finds words that make up of letters inside the textbox.
            // Used try/catch to detect error from user input.
            else if (rbScrabble.Checked)
            {
                lbWordSearch.BeginUpdate();
                lbWordSearch.Items.Clear();
                List<string> wordScrabble = word.ScrabbleWord(txtUser.Text);
                try
                {
                    if (wordScrabble.Count == 0 || wordScrabble.Contains("") || string.IsNullOrWhiteSpace(txtUser.Text))
                    {
                        throw new Exception();
                    }
                    labelError.Visible = false;
                    foreach (string scrabble in wordScrabble)
                    {
                        if (scrabble != wordScrabble[0])
                            lbWordSearch.Items.Add(scrabble);
                    }
                }
                catch (Exception)
                {
                    labelError.Text = "Invalid Input";
                    labelError.Visible = true;
                }
                // If no words are found, print out message
                lbWordSearch.EndUpdate();
            }

            // Find morph words of the word inside the textbox.
            // Used try/catch to detect error from user input.
            else if (rbMorphWord.Checked)
            {
                lbWordSearch.BeginUpdate();
                lbWordSearch.Items.Clear();
                string[] wordMorph = word.MorphWord(txtUser.Text);
                try
                {
                    // If no words are found, print out message
                    if (wordMorph.Length == 0 || string.IsNullOrEmpty(txtUser.Text))
                    {
                        throw new Exception();
                    }
                    labelError.Visible = false;
                    foreach (string morph in wordMorph)
                    {
                        lbWordSearch.Items.Add(morph);
                    }
                }
                catch (Exception)
                {
                    labelError.Text = "Invalid Input";
                    labelError.Visible = true;
                }
                lbWordSearch.EndUpdate();
            }

            // Finds morph chain of start and end word with maximum chain length.
            // Used try/catch to detect error from user input.
            else if (rbMorphChain.Checked)
            {
                lbWordSearch.BeginUpdate();
                lbWordSearch.Items.Clear();
                try
                {
                    int maxLength = Int32.Parse(tbMax.Text);
                    List<string> wordChain = word.MorphChain(txtUser.Text, tbEnd.Text, maxLength);
                    if (wordChain.Count == 0)
                    {
                        labelError.Text = "No Solution";
                        labelError.Visible = true;
                    }
                    if (string.IsNullOrEmpty(txtUser.Text))
                    {
                        throw new Exception();
                    }
                    labelError.Visible = false;
                    foreach (string chain in wordChain)
                    {
                        lbWordSearch.Items.Add(chain);
                    }
                }
                catch
                {
                    labelError.Text = "Invalid Input";
                    labelError.Visible = true;
                }
                lbWordSearch.EndUpdate();
            }
        }

        /// <summary>
        /// A help button that is provided for the user for instructions on how to use our program by a click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelHelp_Click(object sender, EventArgs e)
        {
            string msgStr = String.Format("Welcome to our program!\n-------------------------------The First Column-------------------------------\nFill - prints all the words in the dictionary.\nClear - clears all the words in the textbox. \nYou can select word by clicking the word in the current textbox or search a word by typing in the textbox above Start Word.\n------------------------------The Second Column-----------------------------\nPick an option to rhyme, scrabble, morph, or even morph chain your desired word.  You can begin by typing above the Start Word.\nEnd Word and Max Length inputs are exclusive only to the Morph Word option.\n\n                                                          Enjoy!");
            MessageBox.Show(msgStr);
        }
    }
}
