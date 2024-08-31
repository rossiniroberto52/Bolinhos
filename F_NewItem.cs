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
    public partial class F_NewItem : Form
    {
        public F_NewItem()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string name = tb_name.Text;
            string val = mtb_price.Text;
            
            
            MessageBox.Show(val);
            
            Item item = new Item();
            item.T_NAME = name;
            item.T_VALUE = val;
            Banco.NewItem(item);
        }
    }
}
