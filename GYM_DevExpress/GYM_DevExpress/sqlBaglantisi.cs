﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GYM_DevExpress
{
    class sqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-AEIKMAC\SQLEXPRESS; Initial Catalog=dboGymOtomasyon; Integrated Security=True;");

            baglan.Open();
            return baglan;
        }
    }
}
