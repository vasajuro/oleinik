using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace oleinik
{
    internal class DBConn
    { 
        public static DataTable select(string sql)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "cfif31.ru";
            builder.Port = 3306;
            builder.UserID = "ISPr24-40_OleinikVP";
            builder.Password = "ISPr24-40_OleinikVP";
            builder.Database = "ISPr24-40_OleinikVP_Accounting";
            MySqlConnection con = new MySqlConnection(builder.ConnectionString);
            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand(sql, con);
                MySqlDataReader red = command.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(red);
                return table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка!" + ex.Message);
                return null;
            }
        }
    }
}
