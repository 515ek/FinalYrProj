using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using test4.App_Code;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace test4
{
    public partial class Index : System.Web.UI.Page
    {
        public static bool first = true;
        public static Stack stl = new Stack();
        public static Stack stm = new Stack();
        public static Stack sth = new Stack();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Adv_Click(object sender, EventArgs e)
        {
            Response.Redirect("Adv.aspx");
        }

        protected void Cust_Click(object sender, EventArgs e)
        {
            Response.Redirect("Response.aspx");
            
        }
    }
}