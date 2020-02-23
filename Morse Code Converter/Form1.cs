using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morse_Code_Converter
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> morseCodeTable = new Dictionary<string, string>()
        {
            {".",".-.-.-"}, {",", "--..--"}, {"?", "..--.."}, {"a", ".-"}, {"b", "-..."}, {"c", "-.-."}
            , {"d", "-.."}, {"e", "."}, {"f", "..-."}, {"g", "--."}, {"h", "...."}, {"i", ".."}
            , {"j", ".---"}, {"k", "-.-"}, {"l", ".-.."}, {"m", "---"}, {"n", "-."}
            , {"o", "---"}, {"p", ".--."}, {"q", "--.-"}, {"r", ".-."}, {"s", "..."}, {"t", "-"}
            , {"u", "..-"}, {"v", "...-"}, {"w", ".--"}, {"x", "-..-"}, {"y", "-.--"}, {"z", "--.."}
            , {"0", "-----"}, {"1", ".----"}, {"2", "..---"}, {"3", "...--"}, {"4", "....-"}, {"5", "....."}
            , {"6", "-...."}, {"7", "--..."}, {"8", "---.."}, {"9", "----."}
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clear text box
            stringInput.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //exit form
            this.Close();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            
            string userInput = stringInput.Text; //initialize the input
            string userSentence = userInput.ToLower(); //take the input and turn it into lowercase to match the dictionary
            string output = "";
            foreach (char letter in userSentence) //cycles through each letter in the sentence
            {
                     
                //FirstOrDefault returns the first match it finds in the dictionary and the ?? returns the / in between each word.
                var sentence = morseCodeTable.FirstOrDefault(x => x.Key == letter.ToString()).Value ?? " / ";
                output += sentence;
            }

            stringInput.Text = output;
            
        }
    }
}
