using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace Survey
{
    public partial class index : System.Web.UI.Page
    {
        public string GetConnectionString()
        {
            //sets the connection string from your web config file "ConString" is the name of your Connection String
            return System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }

        private void ExecuteInsert(string userid, string ansq1, string ansq2a, string ansq2b, string ansq2c, string ansq2d, string ansq3, 
            string ansq4, string ansq4a, string ansq5a, string ansq5b, string ansq5c, string ansq5d, string ansq5e, string ansq5f, string ansq5_over, 
            string ansq6a, string ansq6b, string ansq6c, string ansq6d, string ansq6e, string ansq6_over, string ansq7, string ansq8, string ansq9, 
            string ansq10, string ansq11a, string ansq11b, string ansq11c, string ansq11d, string ansq12, string ansq13, string ansq14a, string ansq14b, string ansq15,
            string ansq16, string ansq17a, string ansq17b, string ansq17c, string ansq18, string submitdate)

        {
            SqlConnection conn = new SqlConnection(GetConnectionString());
            string sql = "INSERT INTO Survey(UserID, AnsQ1, AnsQ2a, AnsQ2b, AnsQ2c, AnsQ2d, AnsQ3, AnsQ4,"
                         + " AnsQ4a, AnsQ5a, AnsQ5b, AnsQ5c, AnsQ5d, AnsQ5e, AnsQ5f, AnsQ5_Over, AnsQ6a, AnsQ6b, AnsQ6c,"
                         + " AnsQ6d, AnsQ6e, AnsQ6_Over, AnsQ7, AnsQ8, AnsQ9, AnsQ10, AnsQ11a, AnsQ11b, AnsQ11c, AnsQ11d, AnsQ12,"
                         + " AnsQ13, AnsQ14a, AnsQ14b, AnsQ15, AnsQ16, AnsQ17a, AnsQ17b, AnsQ17c, AnsQ18, SubmitDate  "
                         + ") VALUES (@UserID, @AnsQ1, @AnsQ2a, @AnsQ2b, @AnsQ2c, @AnsQ2d, @AnsQ3, @AnsQ4,"
                         + " @AnsQ4a, @AnsQ5a, @AnsQ5b, @AnsQ5c, @AnsQ5d, @AnsQ5e, @AnsQ5f, @AnsQ5_Over, @AnsQ6a, @AnsQ6b, @AnsQ6c,"
                         + " @AnsQ6d, @AnsQ6e, @AnsQ6_Over, @AnsQ7, @AnsQ8, @AnsQ9, @AnsQ10, @AnsQ11a, @AnsQ11b, @AnsQ11c, @AnsQ11d, @AnsQ12,"
                         + " @AnsQ13, @AnsQ14a, @AnsQ14b, @AnsQ15, @AnsQ16, @AnsQ17a, @AnsQ17b, @AnsQ17c, @AnsQ18, @SubmitDate)";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlParameter[] param = new SqlParameter[41];
                //param[0] = new SqlParameter("@id", SqlDbType.Int, 20);
                param[0] = new SqlParameter("@UserID", SqlDbType.NVarChar, 50);
                param[1] = new SqlParameter("@AnsQ1", SqlDbType.NVarChar, 10);
                param[2] = new SqlParameter("@AnsQ2a", SqlDbType.NVarChar, 10);
                param[3] = new SqlParameter("@AnsQ2b", SqlDbType.NVarChar, 10);
                param[4] = new SqlParameter("@AnsQ2c", SqlDbType.NVarChar, 10);
                param[5] = new SqlParameter("@AnsQ2d", SqlDbType.NVarChar, 10);
                param[6] = new SqlParameter("@AnsQ3", SqlDbType.NVarChar, 10);
                param[7] = new SqlParameter("@AnsQ4", SqlDbType.Text);
                param[8] = new SqlParameter("@AnsQ4a", SqlDbType.NVarChar, 10);
                param[9] = new SqlParameter("@AnsQ5a", SqlDbType.NVarChar, 10);
                param[10] = new SqlParameter("@AnsQ5b", SqlDbType.NVarChar, 10);
                param[11] = new SqlParameter("@AnsQ5c", SqlDbType.NVarChar, 10);
                param[12] = new SqlParameter("@AnsQ5d", SqlDbType.NVarChar, 10);
                param[13] = new SqlParameter("@AnsQ5e", SqlDbType.NVarChar, 10);
                param[14] = new SqlParameter("@AnsQ5f", SqlDbType.NVarChar, 10);
                param[15] = new SqlParameter("@AnsQ5_Over", SqlDbType.NVarChar, 10);
                param[16] = new SqlParameter("@AnsQ6a", SqlDbType.NVarChar, 10);
                param[17] = new SqlParameter("@AnsQ6b", SqlDbType.NVarChar, 10);
                param[18] = new SqlParameter("@AnsQ6c", SqlDbType.NVarChar, 10);
                param[19] = new SqlParameter("@AnsQ6d", SqlDbType.NVarChar, 10);
                param[20] = new SqlParameter("@AnsQ6e", SqlDbType.NVarChar, 10);
                param[21] = new SqlParameter("@AnsQ6_Over", SqlDbType.NVarChar, 10);
                param[22] = new SqlParameter("@AnsQ7", SqlDbType.Text);
                param[23] = new SqlParameter("@AnsQ8", SqlDbType.Text);
                param[24] = new SqlParameter("@AnsQ9", SqlDbType.Text);
                param[25] = new SqlParameter("@AnsQ10", SqlDbType.Text);
                param[26] = new SqlParameter("@AnsQ11a", SqlDbType.NVarChar, 10);
                param[27] = new SqlParameter("@AnsQ11b", SqlDbType.NVarChar, 10);
                param[28] = new SqlParameter("@AnsQ11c", SqlDbType.NVarChar, 10);
                param[29] = new SqlParameter("@AnsQ11d", SqlDbType.NVarChar, 10);
                param[30] = new SqlParameter("@AnsQ12", SqlDbType.Text);
                param[31] = new SqlParameter("@AnsQ13", SqlDbType.NVarChar, 10);
                param[32] = new SqlParameter("@AnsQ14a", SqlDbType.Text);
                param[33] = new SqlParameter("@AnsQ14b", SqlDbType.Text);
                param[34] = new SqlParameter("@AnsQ15", SqlDbType.Text);
                param[35] = new SqlParameter("@AnsQ16", SqlDbType.NVarChar, 10);
                param[36] = new SqlParameter("@AnsQ17a", SqlDbType.NVarChar, 10);
                param[37] = new SqlParameter("@AnsQ17b", SqlDbType.NVarChar, 10);
                param[38] = new SqlParameter("@AnsQ17c", SqlDbType.NVarChar, 10);
                param[39] = new SqlParameter("@AnsQ18", SqlDbType.Text);
                param[40] = new SqlParameter("@SubmitDate", SqlDbType.NVarChar, 10);
                

                param[0].Value = userid;
                param[1].Value = ansq1;
                param[2].Value = ansq2a;
                param[3].Value = ansq2b;
                param[4].Value = ansq2c;
                param[5].Value = ansq2d;
                param[6].Value = ansq3;
                param[7].Value = ansq4;
                param[8].Value = ansq4a;
                param[9].Value = ansq5a;
                param[10].Value = ansq5b;
                param[11].Value = ansq5c;
                param[12].Value = ansq5d;
                param[13].Value = ansq5e;
                param[14].Value = ansq5f;
                param[15].Value = ansq5_over;
                param[16].Value = ansq6a;
                param[17].Value = ansq6b;
                param[18].Value = ansq6c;
                param[19].Value = ansq6d;
                param[20].Value = ansq6e;
                param[21].Value = ansq6_over;
                param[22].Value = ansq7;
                param[23].Value = ansq8;
                param[24].Value = ansq9;
                param[25].Value = ansq10;
                param[26].Value = ansq11a;
                param[27].Value = ansq11b;
                param[28].Value = ansq11c;
                param[29].Value = ansq11d;
                param[30].Value = ansq12;
                param[31].Value = ansq13;
                param[32].Value = ansq14a;
                param[33].Value = ansq14b;
                param[34].Value = ansq15;
                param[35].Value = ansq16;
                param[36].Value = ansq17a;
                param[37].Value = ansq17b;
                param[38].Value = ansq17c;
                param[39].Value = ansq18;
                param[40].Value = submitdate;

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

        public void CheckUserLogin(string username)
        {
            try
            {
                string query = "select * from Survey where UserID = '" + username + "'";
                DataTable dt = LoadData(query);
                if (dt.Rows.Count > 0)
                {
                    Response.Redirect("thanks.aspx");
                }
                else
                {
                    Response.Redirect("index.aspx");
                }
            }
            catch (Exception)
            {
                Response.Redirect("deny.aspx");
            }

        }

        public static DataTable LoadData(string query)
        {
            string strcnn = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(strcnn);
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            string UserLogin = HttpContext.Current.User.Identity.Name;
            UserLogin = UserLogin.Replace("KEPPELLAND\\", "");
            
            CheckUserLogin(UserLogin.ToLower());
            
            if (!Page.IsPostBack)
            {
                string username = UserLogin.ToUpper();

                string q1 = Request["q1_1"];
                string q2a = Request["q2_1"];
                string q2b = Request["q2_2"];
                string q2c = Request["q2_3"];
                string q2d = Request["q2_4"];
                string q3 = Request["q3"];
                string q4 = Request["q41"];
                string q4a = Request["q5a"];
                string q5a = Request["q5_1"];
                string q5b = Request["q5_2"];
                string q5c = Request["q5_3"];
                string q5d = Request["q5_4"];
                string q5e = Request["q5_5"];
                string q5f = Request["q5_6"];
                string q5_over = Request["q5_7"];
                string q6a = Request["q6_1"];
                string q6b = Request["q6_2"];
                string q6c = Request["q6_3"];
                string q6d = Request["q6_4"];
                string q6e = Request["q6_5"];
                string q6_over = Request["q6_6"];
                string q7 = Request["q7"];
                string q8 = Request["q8"];
                string q9 = Request["q9"];
                string q10 = Request["q10"];
                string q11a = Request["q11_1"];
                string q11b = Request["q11_2"];
                string q11c = Request["q11_3"];
                string q11d = Request["q11_4"];
                string q12 = Request["q12"];
                string q13 = Request["q13"];
                string q14a = Request["q14_1"];
                string q14b = Request["q14_2"];
                string q15 = Request["q15"];
                string q16 = Request["q16"];
                string q17a = Request["q17_1"];
                string q17b = Request["q17_2"];
                string q17c = Request["q17_3"];
                string q18 = Request["q18"];
                string date = DateTime.Now.ToShortTimeString();
                ExecuteInsert(username, q1, q2a, q2b, q2c, q2d, q3, q4, q4a, q5a, q5b, q5c, q5d, q5e, q5f, q5_over
                    , q6a, q6b, q6c, q6d, q6e, q6_over, q7, q8, q9, q10, q11a, q11b, q11c, q11d, q12, q13, q14a, q14b, q15, q16, q17a, q17b,
                    q17c, q18, date);


                Response.Redirect("thankyou.aspx");
            }

            //if (IsPostBack)
            //{
            
            //}
        }

        
    }
}