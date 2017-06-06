﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Survey
{
    public partial class result : System.Web.UI.Page
    {
        public string GetConnectionString()
        {
            //sets the connection string from your web config file "ConString" is the name of your Connection String
            return System.Configuration.ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void ExecuteInsert(string name, string username, string password, string gender, string age, string address)
        {
            SqlConnection conn = new SqlConnection(GetConnectionString());
            string sql = "INSERT INTO tblRegistration (Name, UserName, Password, Gender, Age, Address) VALUES "
                        + " (@Name,@UserName,@Password,@Gender,@Age,@Address)";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlParameter[] param = new SqlParameter[6];
                //param[0] = new SqlParameter("@id", SqlDbType.Int, 20);
                param[0] = new SqlParameter("@Name", SqlDbType.VarChar, 50);
                param[1] = new SqlParameter("@UserName", SqlDbType.VarChar, 50);
                param[2] = new SqlParameter("@Password", SqlDbType.VarChar, 50);
                param[3] = new SqlParameter("@Gender", SqlDbType.Char, 10);
                param[4] = new SqlParameter("@Age", SqlDbType.Int, 100);
                param[5] = new SqlParameter("@Address", SqlDbType.VarChar, 50);

                param[0].Value = name;
                param[1].Value = username;
                param[2].Value = password;
                param[3].Value = gender;
                param[4].Value = age;
                param[5].Value = address;

                for (int i = 0; i < param.Length; i++)
                {
                    cmd.Parameters.Add(param[i]);
                }

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                string msg = "Insert Error:";
                msg += ex.Message;
                throw new Exception(msg);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}