﻿using System;
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
            for (double i = 1; i <= 25; i*=1.25)
            {
                result += i.ToString() + " | ";
                
            }
            resultLabel.Text = result;
        }
    }
}