﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Timers;

namespace BD_Elektrik.Admin
{
    public partial class WebForm9 : System.Web.UI.Page
    {
     
        protected void Page_Load(object sender, EventArgs e)
        {
            Timer1.Interval = 1000;
            Timer1.Enabled = true;            
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
           
         var Liste = new Proje.Business.WebServisDeneme().DateTime();
         Label1.Text = Liste.ToString();
            
                
        }
    }
}