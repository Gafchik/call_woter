using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using call_woter.Model;
using System.Data;

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

            string conect_str = @"Persist Security Info=False;Trusted_Connection=True;database=dz_db;server=COMPUTER\SQLEXPRESS";
            Proprety_Model temp = new Proprety_Model(weight, type_live, gender);
            using (SqlConnection connection = new SqlConnection(conect_str))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(@"INSERT INTO [dbo].[user]([weight],[type_live],[gender]) VALUES(@weight, @type_live, @gender);", connection))
                {
                    command.Parameters.Add("@weight", SqlDbType.NVarChar).Value = weight;
                    command.Parameters.Add("@type_live", SqlDbType.NVarChar).Value = type_live;
                    command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender;
                   
                    int count = command.ExecuteNonQuery();
                    if (count > 0)
                        MessageBox.Show($"Добавлено {count} полей", "ВСЕ ОГОНЬ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    command.Dispose();
                }
                connection.Close();
            }
            GC.Collect(GC.GetGeneration(temp));
        }
    }
}
