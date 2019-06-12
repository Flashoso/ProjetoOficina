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

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (nomeTextBox.Text.Length == 0){
                    MessageBox.Show("O campo Nome está vazio");
                }
                if (nifTextBox.Text.Length != 9){
                    MessageBox.Show("O campo Nif tem de ter 9 dígitos");
                }
                if (contactoTextBox.Text.Length != 9){
                    MessageBox.Show("O campo Contacto tem de ter 9 dígitos");
                }
                else{
                    MessageBox.Show("Cliente adicionado");
                }
            }
            catch
            {
                return;
            }
            
        }
    }
}
