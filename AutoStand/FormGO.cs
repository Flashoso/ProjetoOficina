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

            textBoxnome.Text = clienteSelecionado.Nome;
            textBoxnif.Text = clienteSelecionado.Contacto;

            listBoxCarros.DataSource = clienteSelecionado.CarroOficina.ToList();
        }

        private void listBoxCarros_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CarroOficina carroSelecionado = (CarroOficina)listBoxCarros.SelectedItem;
                if (carroSelecionado == null){

                    Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
          
                    listBoxCarros.DataSource = clienteSelecionado.CarroOficina.ToList();
                }
                else{

                    listBoxServicos.DataSource = carroSelecionado.Servico.ToList();

                    textBoxMatricula.Text = carroSelecionado.Matricula;
                    textBoxmarca.Text = carroSelecionado.Marca;
                }
            }
            catch{
                return;
            }
        }

        private void buttonAdicionarCarro_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;

            CarroOficina carroOficina = new CarroOficina(textBoxnumerochassi.Text, textBoxmarca.Text, textBoxmodelo.Text, textBoxcombustivel.Text, textBoxMatricula.Text, textBoxkms.Text);

            listBoxCarros.DataSource = clienteSelecionado.CarroOficina.ToList();

            try
            {
                if (textBoxMatricula.Text.Length == 0 || textBoxnumerochassi.Text.Length == 0 || textBoxmarca.Text.Length == 0 || textBoxmodelo.Text.Length == 0 || textBoxcombustivel.Text.Length == 0 || textBoxkms.Text.Length == 0)
                {
                    MessageBox.Show("Preencha todos os campos.");
                }
                
                else
                {
                    clienteSelecionado.CarroOficina.Add(carroOficina);
                    MessageBox.Show("Carro adicionado");
                    AutoStand.SaveChanges();
                }
            }
            catch
            {
                return;
            }
            

            

            

            
        }

        private void listBoxServicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Servico servicoselelecionardo = (Servico)listBoxServicos.SelectedItem;

            listBoxParcelas.DataSource = servicoselelecionardo.Parcelas.ToList();
        }

        private void buttonAdicionarServico_Click(object sender, EventArgs e)
        {
            Servico servico = new Servico(dateTimePickerEntrada.Value.ToString(), dateTimePickerSaida.Value.ToString(), comboBoxtipo.SelectedItem.ToString());

            CarroOficina carroSelecionado = (CarroOficina)listBoxCarros.SelectedItem;
            carroSelecionado.Servico.Add(servico);

            AutoStand.SaveChanges();

            listBoxServicos.DataSource = carroSelecionado.Servico.ToList();

        }


        private void buttonAdicionarParcela_Click(object sender, EventArgs e)
        {
            Servico servicoSelecionado = (Servico)listBoxServicos.SelectedItem;

            Parcela parcela = new Parcela(textBoxValor.Text, textBoxDescricao.Text);

            servicoSelecionado.Parcelas.Add(parcela);

            AutoStand.SaveChanges();

            listBoxParcelas.DataSource = servicoSelecionado.Parcelas.ToList();
        }

        private void listBoxParcelas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Parcela parcelaSelecionado = (Parcela)listBoxParcelas.SelectedItem;
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void buttonRemoverCarros_Click(object sender, EventArgs e)
        {
            CarroOficina carroSelecionado = (CarroOficina)listBoxCarros.SelectedItem;

            if (carroSelecionado == null)
                return;

            AutoStand.Carros.Remove(carroSelecionado);

            AutoStand.SaveChanges();

            Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
            listBoxCarros.DataSource = clienteSelecionado.CarroOficina.ToList();
        }

        private void buttonRemoverServicos_Click(object sender, EventArgs e)
        {
            Servico servicoselecionado = (Servico)listBoxServicos.SelectedItem;

            if (servicoselecionado == null)
                return;

            AutoStand.Servicos.Remove(servicoselecionado);

            AutoStand.SaveChanges();

            CarroOficina carroselecionado = (CarroOficina)listBoxCarros.SelectedItem;
            listBoxServicos.DataSource = carroselecionado.Servico.ToList();
        }

        private void buttonRemoverParcelas_Click(object sender, EventArgs e)
        {
            Parcela parcelaselecionado = (Parcela)listBoxParcelas.SelectedItem;

            if (parcelaselecionado == null)
                return;

            AutoStand.Parcelas.Remove(parcelaselecionado);

            AutoStand.SaveChanges();

            Servico servicoselecionado = (Servico)listBoxServicos.SelectedItem;
            listBoxParcelas.DataSource = servicoselecionado.Parcelas.ToList();
        }
    }
}
