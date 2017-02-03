using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace test4.App_Code
{
    public class KnapSack
    {
        public string[] AID = new string[100];
        public float[] COST = new float[100];
        public float profit = new float();
        public int[] WEIGHT = new int[100];
        public string[] PRIOR = new string[100];
        public DataSet ds = new DataSet();
        public float[,] v = new float[100, 10];
        public string[] x = new string[100];
        public int i, j, c, n, opt;

        public void getds(GetData gt,string slot)
        {
            ds = gt.getknapinp(slot);

        }
        public string gethinp(int cap)
        {
            int i = 0;
            c = cap;
            n = ds.Tables[0].Rows.Count;
            try
            {
                while (i < n)
                {
                    AID[i] = ds.Tables[0].Rows[i]["AID"].ToString();
                    COST[i] = float.Parse(ds.Tables[0].Rows[i]["COST"].ToString());
                    WEIGHT[i] = int.Parse(ds.Tables[0].Rows[i]["WEIGHT"].ToString());
                    PRIOR[i] = ds.Tables[0].Rows[i]["APRIOR"].ToString();
                }

            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {
                AID[i] = "\0";
                COST[i] = 0;
                WEIGHT[i] = 0;
            }
            finally
            {
               profit = knap(n, c);
            }

            return null;
        }
        public float knap(int n, int c)
        {
            for (i = 0; i <= n; i++)
            {
                for (j = 0; j <= c; j++)
                {
                    if (i == 0 || j == 0)
                        v[i, j] = 0;
                    else if (j < WEIGHT[i])
                        v[i, j] = v[i - 1, j];
                    else
                        v[i, j] = v[i - 1, j] > (COST[i] + v[i - 1, j - WEIGHT[i]]) ? v[i - 1, j] : (COST[i] + v[i - 1, j - WEIGHT[i]]);
                }
            }

            i = n;
            j = c;
            while (i != 0 && j != 0)
            {
                if (v[i, j] != v[i - 1, j])
                {
                    x[i] = AID[i];
                    j = j - WEIGHT[i];
                }
                i = i - 1;
            }

            return v[n, c];
        }
    }
}