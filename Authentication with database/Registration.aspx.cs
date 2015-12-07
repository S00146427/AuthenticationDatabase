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

namespace Authentication_with_database
{
    public partial class WebForm1 : System.Web.UI.Page
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

        protected void btnReg_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                command.Connection = conn;

                //Insert data into database
                command.CommandText = "Insert into UserTbl values('" + txtUserName.Text + "','" + GetMd5Hash(txtPassword.Text) + "')";
                command.ExecuteNonQuery();

                //Read data from the database (read info you have entered)

                command.CommandText = "select UserName, UserPassword from usersTbl where UserName='" + txtUserName.Text + "'";
                queryResults = command.ExecuteReader();

                if (queryResults.Read())
                    Label1.Text = queryResults["UserName"] + "has password: " + queryResults["UserPassword"];
                else
                    Label1.Text = "No such User!";

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

            Label2.Text = "The MD5 hash of " + txtPassword.Text + "is" + GetMd5Hash(txtPassword.Text);
        }
    }
}