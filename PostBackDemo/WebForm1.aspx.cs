﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PostBackDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
               Response.Write("this is postback"); // first time it will not display cuz postback is always displayed at second time
                Additems();
            }
            if (!IsPostBack)
            {
                Response.Write("this is the first load "); // first time it will not display cuz postback is always displayed at second time
                
            }
        }
        void Additems()
        {
            List.Items.Add("first");
            List.Items.Add("second");
            List.Items.Add("third");

        }
    }
}