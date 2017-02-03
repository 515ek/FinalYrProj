﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace test4.App_Code
{
    public class Tick1
    {
        private static bool init = true;
        public static int n;
        internal static void update(UpdatePanel upt1,Stack stl)
        {
            string id = null;
            try
            {
                id = stl.Pop().ToString();
            }
            catch
            {
                init = true;
                seed(stl);
                id = stl.Pop().ToString();
            }
            if(id != null)
            {
                string isrc = string.Format("Convert.ashx?ID={0}", id);
                HtmlGenericControl ndiv = new HtmlGenericControl("div");
                HtmlGenericControl img = new HtmlGenericControl("img");
                img.Attributes.Add("src", isrc);
                //ndiv.Attributes.Add("class", "container");
                //ndiv.Controls.Add(img);
                upt1.ContentTemplateContainer.Controls.Add(img);
            }
            
            
        }

        internal static void seed(Stack stl)
        {
            if(init)
            {
                if(stl.Count == 0)
                {
                    DataSet ds = new DataSet();
                    ds = new GetData().seedstack("L");
                    n = ds.Tables[0].Rows.Count;
                    int i = 0;
                    while(i<n)
                    {
                        stl.Push(ds.Tables[0].Rows[i]["AID"].ToString());
                        i++;
                    }

                }
            }
        }
    }
}