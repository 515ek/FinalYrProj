using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.HtmlControls;
using System.Data;
using System.Data.SqlClient;
using test4;


namespace test4.App_Code
{
    public class StoreData
    {
        public StoreData(SetData set, HtmlGenericControl res)
        {
            using (SqlConnection Conn = new SqlConnection(Connection.constr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "StoreAdvsr";
                cmd.Connection = Conn;
                cmd.Parameters.AddWithValue("@ACAT", set.Acat);
                cmd.Parameters.AddWithValue("@ATITLE", set.Atitle);
                cmd.Parameters.AddWithValue("@ADESC", set.Adesc);
                cmd.Parameters.AddWithValue("@ASLOT", set.ASlot);
                cmd.Parameters.AddWithValue("@APRIOR", set.Aprior);
                cmd.Parameters.AddWithValue("@AFNAME", set.AFNAME);
                cmd.Parameters.AddWithValue("@AFDATA", set.AFDATA);
                cmd.Parameters.AddWithValue("@COST", set.Cost());
                cmd.Parameters.AddWithValue("@WEIGHT", set.Weight());
                try
                {
                    Conn.Open();
                    cmd.ExecuteNonQuery();
                    //ds = getfile();
                    res.Attributes.Add("Class", "w3-text-green");
                    res.InnerHtml = "Inserted Successfully...!!";

                }
                catch (Exception ex)
                {
                    res.Attributes.Add("Class", "w3-text-red");
                    res.InnerHtml += ex.Message;
                }
                finally
                {
                    Conn.Close();
                    cmd.Dispose();
                    Conn.Dispose();
                }
            }
        }
    }
}