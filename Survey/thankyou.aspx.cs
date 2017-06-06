using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Survey
{
    public partial class thankyou : System.Web.UI.Page
    {
        public string GetConnectionString()
        {
            //sets the connection string from your web config file "ConString" is the name of your Connection String
            return System.Configuration.ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }        
    }
}