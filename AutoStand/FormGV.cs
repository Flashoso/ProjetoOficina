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
            listBoxCarros.DataSource = AutoStand.Carros.ToList();

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
            CarroVenda carroVenda = new CarroVenda(textBoxExtra.Text, textBoxnumerochassi.Text, textBoxmarca.Text, textBoxmodelo.Text, textBoxcombustivel.Text);

            AutoStand.Carros.Add(carroVenda);

            AutoStand.SaveChanges();
        }

        private void buttonAdicionarExtra_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
            CarroVenda carroSelecionado = (CarroVenda)listBoxCarros.SelectedItem;
            Venda venda = new Venda(dateTimePickerData.Value.ToString(), textBoxEstado.Text, textBoxValor.Text);

            venda.CarroVenda = carroSelecionado;
            clienteSelecionado.Vendas.Add(venda);

            AutoStand.SaveChanges();
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
