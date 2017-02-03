using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using test4.App_Code;



namespace test4
{
    public partial class Adv : System.Web.UI.Page
    {
        public static HtmlGenericControl res = new HtmlGenericControl("p");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            
            SetData set = new SetData(Adcat.SelectedValue,Atitle.Text, Adesc.Text, Adslot.SelectedIndex.ToString(), Adprior.SelectedIndex.ToString(), Adimg.FileBytes, Adimg.FileName);
            StoreData sdata = new StoreData(set,res);
            dbres.Controls.Add(res);
            //Response.AddHeader("REFRESH", "2;url=Index.aspx");
        }
    }
}