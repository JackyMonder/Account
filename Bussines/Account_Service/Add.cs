using DATA.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Account_Service
{
    public class Account_Add
    {
        public void SaveUser(string username, string password)
        {
            // Chuỗi kết nối đến cơ sở dữ liệu
            string connectionString = "Data Source=MYNGOC;Initial Catalog=LOLMINH;User ID=sa";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Users (Username, Password) VALUES (@Username, @Password)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thêm các tham số
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                }
                LOLMINHContext context = new LOLMINHContext();
                context.SaveChanges();
            }
            return;
        }
    }
}