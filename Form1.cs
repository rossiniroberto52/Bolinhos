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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_NewClient f_NewClient = new F_NewClient();
            f_NewClient.ShowDialog();
        }

        private void editarUmJáExistenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Edit_User f_Edit_User = new F_Edit_User();
            f_Edit_User.ShowDialog();
        }

        private void novoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_NewItem f_NewItem = new F_NewItem();
            f_NewItem.ShowDialog();
        }
    }
}
