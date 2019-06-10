using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoStand
{
    public partial class FormGV : Form
    {
        private Model1Container AutoStand;

        public FormGV()
        {
            InitializeComponent();
        }

        private void LerDados()
        {
            listBoxClientes.DataSource = AutoStand.Clientes.ToList<Cliente>();
        }
        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;

            listBoxExtras.DataSource = clienteSelecionado.Vendas.ToList();

            textBoxnome.Text = clienteSelecionado.Nome;
            textBoxnif.Text = clienteSelecionado.Nif;


        }

        private void FormGV_Load(object sender, EventArgs e)
        {
            AutoStand = new Model1Container();
            LerDados();
        }


        private void buttonAdicionarCarro_Click(object sender, EventArgs e)
        {
            CarroVenda carroVenda = new CarroVenda(textBoxnumerochassi.Text, textBoxmarca.Text, textBoxmodelo.Text, textBoxcombustivel.Text);

            AutoStand.Carros.Add(carroVenda);

            AutoStand.SaveChanges();
        }

        private void buttonAdicionarExtra_Click(object sender, EventArgs e)
        {
            Venda venda = new Venda(textBoxValor.Text, textBoxEstado.Text, dateTimePickerData.Value.ToString());

            venda.CarroVenda = carro;
            cliente.Vendas.Add(venda);

            minhaOficina.SaveChanges();
            MessageBox.Show("Alteracões Guardadas");
        }
    }
}
