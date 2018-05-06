using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace String_Stuff
{
    public partial class stringForm : Form
    {
        public stringForm()
        {
            InitializeComponent();
        }

        private string SwitchCase(string input)
       // returns the same string that's passed but with opposite case for character       
        {
            string output = "";
            foreach (char ch in input)
            {
                if (char.IsUpper(ch))
                    output = output + char.ToLower(ch);
                else                
                    output = output + char.ToUpper(ch);                
            }
                return output;            
        }

        private string Reverse(string input)
        // reverses the order of the characters in the string       
        {
            string output = "";
            foreach(char ch in input)
            {
                output = ch + output;
            }

            return output;
        }

        private string PigLatin(string input)
        // returns string that starts with the 2nd character to end of string 
        // appended with 1st character and an "ay"   
        {
            string output = "";
            if (input[0] == 'a' || input[0] == 'e' || input[0] == 'i' || input[0] == 'o' || input[0] == 'u')
            {
                output = input + "yay";
            }
            else
            {
                output = input.Substring(1);
                output = output + input[0] + "ay";
            }            
            return output;
        }

        private string ShiftCypher(string input, int charsToShift)
        // returns a string that translates or codes each character
        // based on shifting to another character in alphabet
        // by the charToShift
        {
            string output = "";
            foreach (char ch in input)
            {
                int asciiValue = (int)ch;
                asciiValue = (((asciiValue - 97) + charsToShift) % 26) + 97;
                output = output + (char)asciiValue;
            }
            return output;
        }

        private string SubCypher(string input, string charsToSub)

        {
            string output = "";
            foreach (char ch in input)
            {
                int asciiValue = (int)ch;
                int index = asciiValue - 97;
                char subCharacter = charsToSub[index];
                output = output + subCharacter;
            }
            return output;
        }

        private void transformButton_Click(object sender, EventArgs e)
        {
            string input = inputTextBox.Text;
            switchCaseTextBox.Text = SwitchCase(input);
            reverseTextBox.Text = Reverse(input);
            pigLatinTextBox.Text = PigLatin(input);
            shiftTextBox.Text = ShiftCypher(input, 2);
            subTextBox.Text = SubCypher(input, "bcdefghijklmnopqrstuvwxyza");

        }
    }
}
