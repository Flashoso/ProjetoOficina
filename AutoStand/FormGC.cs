using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoStand
{
    public partial class FormGC : Form
    {
        private Model1Container AutoStand;

        public FormGC()
        {
            InitializeComponent();

            AutoStand = new Model1Container();
            (from cliente in AutoStand.Clientes
             orderby cliente.Nome
             select cliente).Load();
            clienteBindingSource.DataSource = AutoStand.Clientes.Local.ToBindingList();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            AutoStand.SaveChanges();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }

      
    }
}
