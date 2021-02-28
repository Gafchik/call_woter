using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace call_woter.Control
{
    public interface I_Propertu_Model_Controler
    {
         void Write(string weight, string type_live, string gender);
    }
    class Propertu_Model_Controler : I_Propertu_Model_Controler
    {

        public void Write(string weight, string type_live, string gender)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=mssql;Initial Catalog=shepel_db;Integrated Security=False;"))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(@"INSERT INTO [dbo].[Login]([Login_text],[User_type]) VALUES(@my_login, @my_type);", connection))
                {
                    SqlParameter loginParameter = new SqlParameter("@my_login", "bobik");
                    SqlParameter typeParameter = new SqlParameter("@my_type", "клоун");
                    int count = command.ExecuteNonQuery();
                    if (count > 0)
                        MessageBox.Show($"Добавлено {count} полей", "ВСЕ ОГОНЬ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    command.Dispose();
                }
                connection.Close();
            }
        }
    }
}
