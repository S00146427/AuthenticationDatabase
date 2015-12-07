using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Web.Configuration;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Web.Security;

namespace Authentication_with_database
{
    public partial class Login : System.Web.UI.Page
    {
        static string connString = WebConfigurationManager.ConnectionStrings["ConnectionString1"].ConnectionString;

        SqlConnection conn = new SqlConnection(connString);
        SqlCommand command = new SqlCommand();
        SqlDataReader queryResults;


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        static string GetMd5Hash(string input)
        {
            string output = "";

            using (MD5 md5Hash = MD5.Create())
            {
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

                foreach (byte b in data)
                {
                    output = output + b.ToString("x2");
                }
            }
            return output;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                command.Connection = conn;

                //Create the MD5 Message digest (hash value) for the Password

                string md5Password = GetMd5Hash(txtPasswd.Text);

                //Insert data into database
                command.CommandText = string.Format("select UserName, UserPassword from userTbl where UserName='{0}' and UserPassword='{1}'", txtUName.Text, md5Password);
                queryResults = command.ExecuteReader();

                if (queryResults.Read())

                    FormsAuthentication.RedirectFromLoginPage(txtUName.Text, true);
                else
                    Label1.Text = "No such user or wrong password";

                queryResults.Close();
            }

            catch (Exception ex)
            {
                Label1.Text = ex.Message;
            }

            finally
            {
                conn.Close();
            }

        }
    }
}