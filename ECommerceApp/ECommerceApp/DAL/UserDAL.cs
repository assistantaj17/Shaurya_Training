using ECommerceApp.Models;
using System;
using System.Data.SqlClient;

namespace ECommerceApp.DAL
{
    public class UserDAL
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public UserDAL()
        {
            con = new SqlConnection(Startup.ConnectionString);
        }
        public int UserSignUp(User users)
        {
            string qry = "insert into Users FirstName,LastName,Email,Password values(@first,@last,@email,@pass)";
            cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@first", users.FirstName);
            cmd.Parameters.AddWithValue("@last", users.LastName);
            cmd.Parameters.AddWithValue("email", users.Email);
            cmd.Parameters.AddWithValue("pass", users.Password);
            con.Open();
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;

        }
        public User UserLogin(User users)
        {
            User user = new User();
            string qry = "select * from Users where Email=@email AND Password=@Password";
            cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@email", users.Email);
            cmd.Parameters.AddWithValue("@Password", users.Password);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    user.Id = Convert.ToInt32(dr["Id"]);
                    //user.FirstName = dr["FirstName"].ToString();
                    //user.LastName = dr["LastName"].ToString();
                    user.Email = dr["Email"].ToString();
                    user.Password = dr["Password"].ToString();
                    int isAdmin = 0;
                    user.isAdmin = int.TryParse(dr["IsAdmin"].ToString(), out isAdmin) ? isAdmin : 0;
                }
                con.Close();
                return user;

            }
            else
            {
                return user;
            }
        }
    }
}
    
