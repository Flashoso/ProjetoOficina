﻿using System;
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
        }
    }
}
