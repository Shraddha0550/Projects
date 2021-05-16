using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Camera_House
{
    class Connection_File
    {
        public SqlConnection Con = new SqlConnection(@"Data Source=.\EXPRESS;Initial Catalog=Camera_House_DB;Integrated Security=True");

        public void Con_Open()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
        }

        public void Con_Close()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
        }
    }
}
