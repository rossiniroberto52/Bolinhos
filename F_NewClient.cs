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
    public partial class F_NewClient : Form
    {
        public F_NewClient()
        {
            InitializeComponent();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.T_NAME = tb_Name.Text;
            user.T_CALL_NUM = mtb_call_num.Text;
            user.T_CPF = mtb_cpf.Text;
            user.T_ADDRESS = tb_address.Text;

            Banco.NewUser(user);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_Name.Clear();
            mtb_cpf.Clear();
            mtb_call_num.Clear();
            tb_address.Clear();
            tb_Name.Focus();
        }
    }
}
