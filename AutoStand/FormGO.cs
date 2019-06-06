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
    public partial class FormGO : Form
    {
        private Model1Container AutoStand;

        public FormGO()
        {
            InitializeComponent();
        }

        private void LerDados()
        {
            listBoxClientes.DataSource = AutoStand.Clientes.ToList<Cliente>();
        }

        private void FormGO_Load(object sender, EventArgs e)
        {
            AutoStand = new Model1Container();
            LerDados();
        }

        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;

            textBoxMostrarNome.Text = clienteSelecionado.Nome;
            textBoxContacto.Text = clienteSelecionado.Contacto;

            listBoxCarros.DataSource = clienteSelecionado.CarroOficina.ToList();
        }

        private void listBoxCarros_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarroOficina carroSelecionado = (CarroOficina)listBoxCarros.SelectedItem;
            listBoxServicos.DataSource = carroSelecionado.Servico.ToList();
        }

        private void buttonAdicionarCarro_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;

            CarroOficina carroOficina = new CarroOficina(textBoxnumerochassi.Text, textBoxmarca.Text, textBoxmodelo.Text, textBoxcombustivel.Text, textBoxMatricula.Text, textBoxkms.Text);

            clienteSelecionado.CarroOficina.Add(carroOficina);

            AutoStand.SaveChanges();

            listBoxCarros.DataSource = clienteSelecionado.CarroOficina.ToList();
        }

        private void listBoxServicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Servico servicoselelecionardo = (Servico)listBoxServicos.SelectedItem;
            listBoxParcelas.DataSource = servicoselelecionardo.Parcelas.ToList();
        }

        private void buttonAdicionarServico_Click(object sender, EventArgs e)
        {
            CarroOficina carroSelecionado = (CarroOficina)listBoxCarros.SelectedItem;

            Servico servico = new Servico(dateTimePickerEntrada.Value.ToString(), dateTimePickerSaida.Value.ToString(), comboBoxtipo.SelectedItem.ToString());

            carroSelecionado.Servico.Add(servico);

            AutoStand.SaveChanges();

            listBoxServicos.DataSource = carroSelecionado.Servico.ToList();
        }

        private void listBoxParcelas_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void buttonAdicionarParcela_Click(object sender, EventArgs e)
        {
            Servico servicoSelecionado = (Servico)listBoxServicos.SelectedItem;

            Parcela parcela = new Parcela(textBoxValor.Text, textBoxDescricao.Text);

            servicoSelecionado.Parcelas.Add(parcela);

            AutoStand.SaveChanges();

            listBoxParcelas.DataSource = servicoSelecionado.Parcelas.ToList();
        }
    }
}
