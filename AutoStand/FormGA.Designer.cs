namespace AutoStand
{
    partial class FormGA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxEstado = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxnumerochassi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxcombustivel = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxmarca = new System.Windows.Forms.TextBox();
            this.textBoxmodelo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonAdicionarCarro = new System.Windows.Forms.Button();
            this.textBoxMatricula = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxCarros = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxvalor = new System.Windows.Forms.TextBox();
            this.dateTimePickerSaida = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEntrada = new System.Windows.Forms.DateTimePicker();
            this.textBoxKms = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxAluguer = new System.Windows.Forms.ListBox();
            this.Voltar = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxnif = new System.Windows.Forms.TextBox();
            this.textBoxnome = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestão de Alugueres";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxClientes);
            this.groupBox1.Location = new System.Drawing.Point(31, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 569);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Clientes";
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.Location = new System.Drawing.Point(16, 28);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.ScrollAlwaysVisible = true;
            this.listBoxClientes.Size = new System.Drawing.Size(156, 524);
            this.listBoxClientes.TabIndex = 16;
            this.listBoxClientes.SelectedIndexChanged += new System.EventHandler(this.listBoxClientes_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxEstado);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textBoxnumerochassi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxcombustivel);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBoxmarca);
            this.groupBox2.Controls.Add(this.textBoxmodelo);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.buttonAdicionarCarro);
            this.groupBox2.Controls.Add(this.textBoxMatricula);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.listBoxCarros);
            this.groupBox2.Location = new System.Drawing.Point(257, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 483);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Carros";
            // 
            // textBoxEstado
            // 
            this.textBoxEstado.Location = new System.Drawing.Point(18, 410);
            this.textBoxEstado.Name = "textBoxEstado";
            this.textBoxEstado.Size = new System.Drawing.Size(185, 20);
            this.textBoxEstado.TabIndex = 41;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 394);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "Estado";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(71, 178);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "Criar Carro";
            // 
            // textBoxnumerochassi
            // 
            this.textBoxnumerochassi.Location = new System.Drawing.Point(18, 333);
            this.textBoxnumerochassi.Name = "textBoxnumerochassi";
            this.textBoxnumerochassi.Size = new System.Drawing.Size(185, 20);
            this.textBoxnumerochassi.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Número Chassi";
            // 
            // textBoxcombustivel
            // 
            this.textBoxcombustivel.Location = new System.Drawing.Point(18, 372);
            this.textBoxcombustivel.Name = "textBoxcombustivel";
            this.textBoxcombustivel.Size = new System.Drawing.Size(185, 20);
            this.textBoxcombustivel.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 356);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Combustível";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Modelo";
            // 
            // textBoxmarca
            // 
            this.textBoxmarca.Location = new System.Drawing.Point(18, 254);
            this.textBoxmarca.Name = "textBoxmarca";
            this.textBoxmarca.Size = new System.Drawing.Size(185, 20);
            this.textBoxmarca.TabIndex = 33;
            // 
            // textBoxmodelo
            // 
            this.textBoxmodelo.Location = new System.Drawing.Point(18, 294);
            this.textBoxmodelo.Name = "textBoxmodelo";
            this.textBoxmodelo.Size = new System.Drawing.Size(185, 20);
            this.textBoxmodelo.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Marca";
            // 
            // buttonAdicionarCarro
            // 
            this.buttonAdicionarCarro.Location = new System.Drawing.Point(18, 448);
            this.buttonAdicionarCarro.Name = "buttonAdicionarCarro";
            this.buttonAdicionarCarro.Size = new System.Drawing.Size(185, 23);
            this.buttonAdicionarCarro.TabIndex = 28;
            this.buttonAdicionarCarro.Text = "Adicionar Carro";
            this.buttonAdicionarCarro.UseVisualStyleBackColor = true;
            this.buttonAdicionarCarro.Click += new System.EventHandler(this.buttonAdicionarCarro_Click);
            // 
            // textBoxMatricula
            // 
            this.textBoxMatricula.Location = new System.Drawing.Point(18, 215);
            this.textBoxMatricula.Name = "textBoxMatricula";
            this.textBoxMatricula.Size = new System.Drawing.Size(185, 20);
            this.textBoxMatricula.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Matrícula";
            // 
            // listBoxCarros
            // 
            this.listBoxCarros.FormattingEnabled = true;
            this.listBoxCarros.Location = new System.Drawing.Point(21, 21);
            this.listBoxCarros.Name = "listBoxCarros";
            this.listBoxCarros.ScrollAlwaysVisible = true;
            this.listBoxCarros.Size = new System.Drawing.Size(173, 147);
            this.listBoxCarros.TabIndex = 15;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBoxvalor);
            this.groupBox3.Controls.Add(this.dateTimePickerSaida);
            this.groupBox3.Controls.Add(this.dateTimePickerEntrada);
            this.groupBox3.Controls.Add(this.textBoxKms);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.listBoxAluguer);
            this.groupBox3.Location = new System.Drawing.Point(495, 160);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 483);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Aluguer";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 23);
            this.button1.TabIndex = 40;
            this.button1.Text = "Adicionar Aluguer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Data Saida";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Data Entrada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Valor a Pagar";
            // 
            // textBoxvalor
            // 
            this.textBoxvalor.Location = new System.Drawing.Point(19, 412);
            this.textBoxvalor.Name = "textBoxvalor";
            this.textBoxvalor.Size = new System.Drawing.Size(161, 20);
            this.textBoxvalor.TabIndex = 44;
            // 
            // dateTimePickerSaida
            // 
            this.dateTimePickerSaida.Location = new System.Drawing.Point(18, 372);
            this.dateTimePickerSaida.Name = "dateTimePickerSaida";
            this.dateTimePickerSaida.Size = new System.Drawing.Size(161, 20);
            this.dateTimePickerSaida.TabIndex = 43;
            // 
            // dateTimePickerEntrada
            // 
            this.dateTimePickerEntrada.Location = new System.Drawing.Point(18, 333);
            this.dateTimePickerEntrada.Name = "dateTimePickerEntrada";
            this.dateTimePickerEntrada.Size = new System.Drawing.Size(161, 20);
            this.dateTimePickerEntrada.TabIndex = 42;
            // 
            // textBoxKms
            // 
            this.textBoxKms.Location = new System.Drawing.Point(18, 294);
            this.textBoxKms.Name = "textBoxKms";
            this.textBoxKms.Size = new System.Drawing.Size(161, 20);
            this.textBoxKms.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Quilómetros percorridos";
            // 
            // listBoxAluguer
            // 
            this.listBoxAluguer.FormattingEnabled = true;
            this.listBoxAluguer.Location = new System.Drawing.Point(19, 23);
            this.listBoxAluguer.Name = "listBoxAluguer";
            this.listBoxAluguer.ScrollAlwaysVisible = true;
            this.listBoxAluguer.Size = new System.Drawing.Size(161, 251);
            this.listBoxAluguer.TabIndex = 0;
            // 
            // Voltar
            // 
            this.Voltar.AutoSize = true;
            this.Voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Voltar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Voltar.Location = new System.Drawing.Point(601, 31);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(57, 20);
            this.Voltar.TabIndex = 10;
            this.Voltar.Text = "Voltar";
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxnif);
            this.groupBox5.Controls.Add(this.textBoxnome);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Location = new System.Drawing.Point(245, 74);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(382, 80);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ficha ";
            // 
            // textBoxnif
            // 
            this.textBoxnif.Location = new System.Drawing.Point(70, 49);
            this.textBoxnif.Name = "textBoxnif";
            this.textBoxnif.Size = new System.Drawing.Size(266, 20);
            this.textBoxnif.TabIndex = 16;
            // 
            // textBoxnome
            // 
            this.textBoxnome.Location = new System.Drawing.Point(70, 19);
            this.textBoxnome.Name = "textBoxnome";
            this.textBoxnome.Size = new System.Drawing.Size(266, 20);
            this.textBoxnome.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(41, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Nif:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(29, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Nome:";
            // 
            // FormGA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 666);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormGA";
            this.Text = "FormGA";
            this.Load += new System.EventHandler(this.FormGA_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxnumerochassi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxcombustivel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxmarca;
        private System.Windows.Forms.TextBox textBoxmodelo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonAdicionarCarro;
        private System.Windows.Forms.TextBox textBoxMatricula;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxCarros;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxKms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxAluguer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxvalor;
        private System.Windows.Forms.DateTimePicker dateTimePickerSaida;
        private System.Windows.Forms.DateTimePicker dateTimePickerEntrada;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxEstado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label Voltar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBoxnif;
        private System.Windows.Forms.TextBox textBoxnome;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}