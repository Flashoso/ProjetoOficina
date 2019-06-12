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
    public partial class FormGA : Form
    {
        private Model1Container AutoStand;

        public FormGA()
        {
            InitializeComponent();
        }

        private void LerDados()
        {
            listBoxClientes.DataSource = AutoStand.Clientes.ToList<Cliente>();
            listBoxCarros.DataSource = AutoStand.Carros.ToList();
        }

        private void FormGA_Load(object sender, EventArgs e)
        {
            AutoStand = new Model1Container();
            LerDados();
            
        }
                                            //Adicionar Carro
        private void buttonAdicionarCarro_Click(object sender, EventArgs e)
        {
            CarroAluguer carroAluguer = new CarroAluguer(textBoxnumerochassi.Text, textBoxmarca.Text, textBoxmodelo.Text, textBoxcombustivel.Text, textBoxEstado.Text, textBoxMatricula.Text );

            AutoStand.Carros.Add(carroAluguer);

            AutoStand.SaveChanges();

            listBoxCarros.DataSource = AutoStand.Carros.ToList();
        }

                                            //Adicionar Aluguer
        private void button1_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
            CarroAluguer carroSelecionado = (CarroAluguer)listBoxCarros.SelectedItem;
            Aluguer aluguer = new Aluguer(dateTimePickerEntrada.Value.ToString(), dateTimePickerSaida.Value.ToString(), textBoxvalor.Text, textBoxKms.Text);
            
            aluguer.CarroAluguer = carroSelecionado;
            clienteSelecionado.Alugueres.Add(aluguer);

            AutoStand.SaveChanges();
        }

                                            //Botão Voltar
        private void Voltar_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

                                            //Listar Clientes e Ficha
        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;

            textBoxnome.Text = clienteSelecionado.Nome;
            textBoxnif.Text = clienteSelecionado.Nif;
        }
    }
}
