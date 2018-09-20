
//RPM Assignment
//Author: Sean Purtill
//Sept 20 2018
//This page handles the C# server side of the application








using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    //Server Side function
    protected void btnCSharp_Click(object sender, EventArgs e)
    {
        try
        {
            // Get text from text box
            string newText = tbInput.Text;
            // if there is no input, change output
            if (newText.Length <= 0)
                newText = "No Input.";
            {
                //string for the final output  
                string phrase = "";

                //boolean for punctuation
                bool punctuation = false;

                //check if the last character is a punctuation 
                string last = newText.Substring(newText.Length-1,1);
                if (last == "." || last == "\"" || last == "!" || last == "'" || last == ";" || last == "?")
                {
                    punctuation = true;
                    //trim and add later
                    newText =newText.TrimEnd('.','?','!');
                }

                //separate each word into an array
                string[] words = newText.Split(' ');
                

                //for each word in the newText 
                foreach (var word in words)
                {
                    // for the first letter
                    string W;
                    //for the rest of the word   
                    string ord;
                    //if there are two "  " spaces, there will be an exception.  
                    if (word.Length <= 0 || last.Length <= 0)
                    {
                        W = " ";
                    }
                    
                    else
                    {
                        // separate first letter
                        W = word.Substring(0, 1);
                        //separate whats left of the letter
                        ord = word.Substring(1, word.Length - 1);
                        //Rearrange order and add -ay to the end
                        newText = ord + "-" + W + "ay";
                        //add to output
                        phrase += newText + " ";

                    }
                }
                //if there was punctuation, add at the end.
                if (punctuation == true)
                {
                    phrase = phrase.TrimEnd(' ') + last;
                }
                //change label to output
                lbOutput.Text = phrase.TrimEnd(' ');

            }

        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: '{0}'", arg0: e);
        }
     }
    
}