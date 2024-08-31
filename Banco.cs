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

        public static DataTable GetAllUsers_Id_Name() //dgv clients mananger
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = conectDB();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT N_ID as 'ID', T_NAME as 'Nome' FROM tb_client";
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

        public static DataTable GetDataUser(string id) 
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = conectDB();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM tb_client WHERE N_ID = '" + id + "'";
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

        //clients control --START--

        //client mananger (UPDATE && DELETE)
        public static void UpdateClient(User user) 
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = conectDB();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "UPDATE tb_client SET T_NAME = '"+user.T_NAME+"', T_CALL_NUM = '"+user.T_CALL_NUM+"', T_CPF = '"+user.T_CPF+"', T_ADDRESS = '"+user.T_ADDRESS+"' WHERE N_ID = '"+user.N_ID+"'";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void DelClient(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = conectDB();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "DELETE FROM tb_client WHERE N_ID = " + id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        public static void NewUser(User user)  //new user 
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
                cmd.CommandText = "INSERT INTO tb_client (T_NAME, T_CALL_NUM, T_CPF, T_ADDRESS) VALUES (@name, @CallNum, @cpf, @address)";
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

        //clients control --END--

        //itens control --START--

        public static bool ItemFind(Item item)
        {
            bool res;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            var vcon = conectDB();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = "SELECT T_NAME FROM tb_items WHERE T_NAME = '" + item + "'";
            da = new SQLiteDataAdapter(cmd.CommandText, vcon);
            da.Fill(dt);
            if (dt.Rows.Count > 0) { res = true; } else { res = false; }
            vcon.Close();
            return res;
        }

        public static void NewItem(Item item)
        {
            if (ItemFind(item))
            {
                MessageBox.Show("Item já cadastrado!");
                return;
            }
            try
            {
                var vcon = conectDB();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "INSERT INTO tb_items (T_NAME, T_VALUE) VALUES (@name, @val)";
                cmd.Parameters.AddWithValue("@name", item.T_NAME);
                cmd.Parameters.AddWithValue("@val", item.T_VALUE);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Novo item cadastrado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error to save new item on db");
                MessageBox.Show(ex.Message);
                throw ex;
            }
        }
    }
}
