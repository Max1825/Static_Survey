using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;

namespace Survey
{
    public partial class report : System.Web.UI.Page
    {
        public string GetConnectionString()
        {
            //sets the connection string from your web config file "ConString" is the name of your Connection String
            return System.Configuration.ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                //Populating a DataTable from database.
                DataTable dt = this.GetData();
                DataSet ds = this.CountUser();
                Label1.Text = "Total User do survey:  " + ds.Tables[0].Rows.Count.ToString();
                //Building an HTML string.
                StringBuilder html = new StringBuilder();

                //Table start.
                html.Append("<table class='question-matrix-nps-table table-reset' cellspacing='0'>");

                //Building the Header row.
                html.Append("<tbody>");
                html.Append("<tr>");
               // foreach (DataColumn column in dt.Columns)
               // {
                    html.Append("<th style='background-color:#b7dde8;'>");
                    //html.Append(column.ColumnName);
                    html.Append("User Name");
                    html.Append("</th>");
                    html.Append("<th style='background-color:#b7dde8;'>");
                    //html.Append(column.ColumnName);
                    html.Append("Submit Time");
                    html.Append("</th>");
                // }
                html.Append("</tr>");

                //Building the Data rows.
                foreach (DataRow row in dt.Rows)
                {
                    html.Append("<tr>");
                    foreach (DataColumn column in dt.Columns)
                    {
                        html.Append("<td style='padding-top:5px;padding-bottom:5px;border:solid 1px #b7dde8'>");
                        html.Append(row[column.ColumnName]);
                        html.Append("</td>");
                    }
                    html.Append("</tr>");
                }

                //Table end.
                html.Append("</tbody>");
                html.Append("</table>");

                //Append the HTML string to Placeholder.
                PlaceHolder1.Controls.Add(new Literal { Text = html.ToString() });
            }
        }

        private DataTable GetData()
        {
            string constr = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT UserID, SubmitDate FROM Survey"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }

        private DataSet CountUser()
        {            
            string constr = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            SqlConnection connection = new SqlConnection(constr);
            DataSet ds = new DataSet();
            string sql = "SELECT UserID FROM Survey";            
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            adapter.Fill(ds);
            return ds;
        }
    }
}