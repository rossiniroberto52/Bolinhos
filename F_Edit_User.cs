using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_mama
{
    public partial class F_Edit_User : Form
    {
        public F_Edit_User()
        {
            InitializeComponent();
        }

        private void F_Edit_User_Load(object sender, EventArgs e)
        {
            dgv_clients.DataSource = Banco.GetAllUsers_Id_Name();
            dgv_clients.Columns[0].Width = 60;
            dgv_clients.Columns[1].Width = 230;
        }

        private void dgv_clients_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int ContLines = dgv.SelectedRows.Count;
            if (ContLines > 0)
            {
                try
                {
                    DataTable dt = new DataTable();
                    string id = dgv.SelectedRows[0].Cells[0].Value.ToString();
                    dt = Banco.GetDataUser(id);
                    tb_id.Text = dt.Rows[0].Field<Int64>("N_ID").ToString();
                    tb_Name.Text = dt.Rows[0].Field<string>("T_NAME");
                    mtb_call_num.Text = dt.Rows[0].Field<string>("T_CALL_NUM");
                    mtb_cpf.Text = dt.Rows[0].Field<string>("T_CPF");
                    tb_address.Text = dt.Rows[0].Field<string>("T_ADDRESS");
                }
                catch (Exception ex) 
                {
                    throw ex;
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F_NewClient f_NewClient = new F_NewClient();
            f_NewClient.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.N_ID = Convert.ToInt32(tb_id.Text);
            u.T_NAME = tb_Name.Text;
            u.T_CALL_NUM = mtb_call_num.Text;
            u.T_CPF = mtb_cpf.Text;
            u.T_ADDRESS = tb_address.Text;
            Banco.UpdateClient(u);
            dgv_clients.DataSource = Banco.GetAllUsers_Id_Name();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = tb_id.Text;
            DialogResult DeleteConfirm = MessageBox.Show("Você realmente quer DELETAR esse cliente? \n OBS: Esta ação não tem retorno!", "Deletar!?", MessageBoxButtons.YesNo);
            if (DeleteConfirm == DialogResult.Yes) 
            {
                Banco.DelClient(id);
            }
            dgv_clients.DataSource = Banco.GetAllUsers_Id_Name();
        }
    }
}
