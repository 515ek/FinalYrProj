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
    public partial class Response : System.Web.UI.Page
    {
        //public static HtmlGenericControl img = new HtmlGenericControl("img");
        //GetData gt = new GetData();
        //int id = 2002;
        
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void t1_Tick(object sender, EventArgs e)
        {          
            Tick1.update(upr1,Index.stl);
            Tick1.update(upr4, Index.stl);
            Tick1.update(upr3, Index.stl);
            Tick1.update(upr2, Index.stl);
        }

        protected void t2_Tick(object sender, EventArgs e)
        {
            Tick2.update(upl1, Index.stm);
            Tick2.update(upl4, Index.stm);
            Tick2.update(upl3, Index.stm);
            Tick2.update(upl2, Index.stm);
            Tick2.update(upl6, Index.stm);
            Tick2.update(upl7, Index.stm);
            Tick2.update(upl8, Index.stm);
            Tick2.update(upl5, Index.stm);
        }        

        protected void t3_Tick(object sender, EventArgs e)
        {
            Tick3.update(upt1, Index.sth);
            Tick3.update(upt4, Index.sth);
            Tick3.update(upt3, Index.sth);
            Tick3.update(upt2, Index.sth);
            Tick3.update(upt6, Index.sth);
            Tick3.update(upt7, Index.sth);
            Tick3.update(upt8, Index.sth);
            Tick3.update(upt5, Index.sth);
        }

    }
}