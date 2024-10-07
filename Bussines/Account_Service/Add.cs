using DATA.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Account_Service
{
    using Feature.Tools;

    public class Account_Add
    {
        public void SaveUser(string username, string password, int numb)
        {
            // Chuỗi kết nối đến cơ sở dữ liệu
            string connectionString = "Data Source=MYNGOC;Initial Catalog=QLKho;Persist Security Info=True;User ID=sa;Password=12345;Trust Server Certificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Account (User_ID, Username, Password, Role) VALUES (@User_ID, @Username, @Password, @Role)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thêm các tham số
                    int role;
                    string user_id = RandomString.GenerateRandomString(7);

                    command.Parameters.AddWithValue("@User_ID", user_id);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    switch (numb)
                    {
                        case 0 :
                            role = 0;
                            command.Parameters.AddWithValue("@Role", role);
                            break;
                        case 111:
                            role = 1;
                            command.Parameters.AddWithValue("@Role", role);
                            break;
                    }

                    command.ExecuteNonQuery();  // Trả về số dòng bị ảnh hưởng
                    connection.Close();
                }
            }
            return;
        }   
    }
}