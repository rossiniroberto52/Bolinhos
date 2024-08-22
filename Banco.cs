using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace project_mama
{
    internal class Banco
    {
        private static SQLiteConnection conect;
        private static SQLiteConnection conectDB()
        {
            conect = new SQLiteConnection("Data Source = " + Global.PathDB);
            conect.Open();
            return conect;
        }

        public static DataTable GetAllUsers()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = conectDB();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM tb_usuarios";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static bool UserFind(User user)
        {
            bool res;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            var vcon = conectDB();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = "SELECT T_NAME FROM tb_client WHERE T_NAME = '" +  user + "'";
            da = new SQLiteDataAdapter(cmd.CommandText, vcon);
            da.Fill(dt);
            if (dt.Rows.Count > 0) { res = true; } else { res = false; }
            vcon.Close();
            return res;
        }
        
        public static void NewUser(User user) 
        {
            if (UserFind(user))
            {
                MessageBox.Show("Usuario já cadastrado!");
                return;
            }
            try
            {
                var vcon = conectDB();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "INSERT INTO tb_client (T_NAME, T_CALL_NUM, T_CPF, T_ADDRESS) VALUES (@name, @CallNum, @cpf @address)";
                cmd.Parameters.AddWithValue("@name", user.T_NAME);
                cmd.Parameters.AddWithValue("@CallNum", user.T_CALL_NUM);
                cmd.Parameters.AddWithValue("@cpf", user.T_CPF);
                cmd.Parameters.AddWithValue("@address", user.T_ADDRESS);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Novo usuario cadastrado com exito!");
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error to save new User on DataBase");
                MessageBox.Show(ex.Message);
                throw ex;
            }
        }
    }
}
