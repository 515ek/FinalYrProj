using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using test4.App_Code;
namespace test4
{
    /// <summary>
    /// Summary description for Convert
    /// </summary>
    public class Convert : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string ID = "";

            // get the ID from the querystring


            // get the FileName from the querystring
            if (context.Request.QueryString["ID"] != null)
            {
                ID = context.Request.QueryString["ID"].ToString();
            }



            DataSet ds = GetData.getiadvsr(ID);
            Byte[] bytes = (Byte[])ds.Tables[0].Rows[0]["AFDATA"];
            try
            {
                context.Response.Clear();
                context.Response.BinaryWrite(bytes);
                context.Response.Flush();
            }
            catch (Exception ex)
            {
                context.Response.ContentType = "text/plain";
                context.Response.Write(ex.Message);
            }
            finally
            {
                context.Response.End();
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}