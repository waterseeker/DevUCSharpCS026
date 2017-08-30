using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevUCSharpCS_ASP_026
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string result = "";

            //for (int i = 0; i < 10; i++)
            //{
            //    result += i.ToString() + " | ";
            //}
            //resultLabel.Text = result;

            //playing with values and operations
            //for (double i = 1; i <= 25; i*=1.25)
            //{
            //    result += i.ToString() + " | ";

            //}
            //resultLabel.Text = result;

            //looping through an array
            //string[] names = new string[] { "Wolverine", "Cyclops", "Professor X", "Phoenix" };

            ////re-indexes the array, sorting alphabetically
            //Array.Sort(names);
            ////reverses the array
            //Array.Reverse(names);

            //for (int i = 0; i < names.Length; i++)
            //{
            //    result += names[i] + " | ";
            //}
            //resultLabel.Text = result;


            //using a break statement to exit the loop without having to loop through
            //the entire data set, in this case the string array
            string[] names = new string[] { "Wolverine", "Cyclops", "Professor X", "Phoenix" };

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == "Phoenix")
                {
                    result = String.Format("{0} is at index {1} in the list.", names[i], i);
                    break;
                }

            }
            resultLabel.Text = result;
        }
    }
}