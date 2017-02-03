using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using test4;

namespace test4.App_Code
{
    public class Connection
    {
        public static string constr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AppData;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";
    }
}