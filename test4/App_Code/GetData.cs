using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace test4.App_Code
{
    public class GetData
    {
        public DataSet getknapinp(string at)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter();

            using (SqlConnection conn = new SqlConnection(Connection.constr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Getknapinp";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@ASLOT", at);

                try
                {
                    conn.Open();

                    sda.SelectCommand = cmd;
                    sda.Fill(ds);

                    return ds;
                }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
                catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
                {
                    return null;
                }
                finally
                {
                    sda.Dispose();
                    conn.Close();
                    cmd.Dispose();
                    conn.Dispose();
                }
            }
        }

        public static DataSet getiadvsr(string at)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter();

            using (SqlConnection conn = new SqlConnection(Connection.constr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Getiadvsr";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@AID", at);

                try
                {
                    conn.Open();

                    sda.SelectCommand = cmd;
                    sda.Fill(ds);

                    return ds;
                }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
                catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
                {
                    return null;
                }
                finally
                {
                    sda.Dispose();
                    conn.Close();
                    cmd.Dispose();
                    conn.Dispose();
                }
            }
        }

        public DataSet seedstack(string at)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter();

            using (SqlConnection conn = new SqlConnection(Connection.constr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Seedstack";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@APRIOR", at);

                try
                {
                    conn.Open();

                    sda.SelectCommand = cmd;
                    sda.Fill(ds);

                    return ds;
                }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
                catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
                {
                    return null;
                }
                finally
                {
                    sda.Dispose();
                    conn.Close();
                    cmd.Dispose();
                    conn.Dispose();
                }
            }
        }

    }
}