namespace AutoStand
{
    partial class FormGV
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxnif = new System.Windows.Forms.TextBox();
            this.textBoxnome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxnumerochassi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxcombustivel = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxmarca = new System.Windows.Forms.TextBox();
            this.textBoxmodelo = new System.Windows.Forms.TextBox();
            this.textBoxExtra = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonAdicionarCarro = new System.Windows.Forms.Button();
            this.textBoxMatricula = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxCarros = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerData = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxEstado = new System.Windows.Forms.TextBox();
            this.buttonAdicionarVenda = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.listboxVenda = new System.Windows.Forms.ListBox();
            this.Voltar = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestão de Vendas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxClientes);
            this.groupBox1.Location = new System.Drawing.Point(24, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 513);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Clientes";
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.Location = new System.Drawing.Point(16, 28);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.ScrollAlwaysVisible = true;
            this.listBoxClientes.Size = new System.Drawing.Size(156, 459);
            this.listBoxClientes.TabIndex = 16;
            this.listBoxClientes.SelectedIndexChanged += new System.EventHandler(this.listBoxClientes_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxnif);
            this.groupBox5.Controls.Add(this.textBoxnome);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Location = new System.Drawing.Point(232, 57);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(323, 94);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ficha ";
            // 
            // textBoxnif
            // 
            this.textBoxnif.Location = new System.Drawing.Point(74, 55);
            this.textBoxnif.Name = "textBoxnif";
            this.textBoxnif.Size = new System.Drawing.Size(217, 20);
            this.textBoxnif.TabIndex = 16;
            // 
            // textBoxnome
            // 
            this.textBoxnome.Location = new System.Drawing.Point(74, 25);
            this.textBoxnome.Name = "textBoxnome";
            this.textBoxnome.Size = new System.Drawing.Size(217, 20);
            this.textBoxnome.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nif:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nome:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textBoxnumerochassi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxcombustivel);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.textBoxmarca);
            this.groupBox2.Controls.Add(this.textBoxmodelo);
            this.groupBox2.Controls.Add(this.textBoxExtra);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.buttonAdicionarCarro);
            this.groupBox2.Controls.Add(this.textBoxMatricula);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.listBoxCarros);
            this.groupBox2.Location = new System.Drawing.Point(232, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 413);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Carros";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(72, 127);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "Criar Carro";
            // 
            // textBoxnumerochassi
            // 
            this.textBoxnumerochassi.Location = new System.Drawing.Point(19, 282);
            this.textBoxnumerochassi.Name = "textBoxnumerochassi";
            this.textBoxnumerochassi.Size = new System.Drawing.Size(185, 20);
            this.textBoxnumerochassi.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Número Chassi";
            // 
            // textBoxcombustivel
            // 
            this.textBoxcombustivel.Location = new System.Drawing.Point(19, 321);
            this.textBoxcombustivel.Name = "textBoxcombustivel";
            this.textBoxcombustivel.Size = new System.Drawing.Size(185, 20);
            this.textBoxcombustivel.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 305);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Combustível";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Modelo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 344);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "Extra/s";
            // 
            // textBoxmarca
            // 
            this.textBoxmarca.Location = new System.Drawing.Point(19, 203);
            this.textBoxmarca.Name = "textBoxmarca";
            this.textBoxmarca.Size = new System.Drawing.Size(185, 20);
            this.textBoxmarca.TabIndex = 33;
            // 
            // textBoxmodelo
            // 
            this.textBoxmodelo.Location = new System.Drawing.Point(19, 243);
            this.textBoxmodelo.Name = "textBoxmodelo";
            this.textBoxmodelo.Size = new System.Drawing.Size(185, 20);
            this.textBoxmodelo.TabIndex = 31;
            // 
            // textBoxExtra
            // 
            this.textBoxExtra.Location = new System.Drawing.Point(19, 353);
            this.textBoxExtra.Name = "textBoxExtra";
            this.textBoxExtra.Size = new System.Drawing.Size(184, 20);
            this.textBoxExtra.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Marca";
            // 
            // buttonAdicionarCarro
            // 
            this.buttonAdicionarCarro.Location = new System.Drawing.Point(18, 379);
            this.buttonAdicionarCarro.Name = "buttonAdicionarCarro";
            this.buttonAdicionarCarro.Size = new System.Drawing.Size(185, 23);
            this.buttonAdicionarCarro.TabIndex = 28;
            this.buttonAdicionarCarro.Text = "Adicionar Carro";
            this.buttonAdicionarCarro.UseVisualStyleBackColor = true;
            this.buttonAdicionarCarro.Click += new System.EventHandler(this.buttonAdicionarCarro_Click);
            // 
            // textBoxMatricula
            // 
            this.textBoxMatricula.Location = new System.Drawing.Point(19, 164);
            this.textBoxMatricula.Name = "textBoxMatricula";
            this.textBoxMatricula.Size = new System.Drawing.Size(185, 20);
            this.textBoxMatricula.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Matrícula";
            // 
            // listBoxCarros
            // 
            this.listBoxCarros.FormattingEnabled = true;
            this.listBoxCarros.Location = new System.Drawing.Point(21, 19);
            this.listBoxCarros.Name = "listBoxCarros";
            this.listBoxCarros.ScrollAlwaysVisible = true;
            this.listBoxCarros.Size = new System.Drawing.Size(173, 95);
            this.listBoxCarros.TabIndex = 15;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateTimePickerData);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.textBoxValor);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.textBoxEstado);
            this.groupBox3.Controls.Add(this.buttonAdicionarVenda);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.listboxVenda);
            this.groupBox3.Location = new System.Drawing.Point(462, 157);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(258, 413);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Venda";
            // 
            // dateTimePickerData
            // 
            this.dateTimePickerData.Location = new System.Drawing.Point(25, 243);
            this.dateTimePickerData.Name = "dateTimePickerData";
            this.dateTimePickerData.Size = new System.Drawing.Size(213, 20);
            this.dateTimePickerData.TabIndex = 46;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(24, 227);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 13);
            this.label15.TabIndex = 45;
            this.label15.Text = "Data";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(23, 282);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 43;
            this.label14.Text = "Valor";
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(25, 298);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(214, 20);
            this.textBoxValor.TabIndex = 44;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 181);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 41;
            this.label13.Text = "Estado";
            // 
            // textBoxEstado
            // 
            this.textBoxEstado.Location = new System.Drawing.Point(26, 197);
            this.textBoxEstado.Name = "textBoxEstado";
            this.textBoxEstado.Size = new System.Drawing.Size(214, 20);
            this.textBoxEstado.TabIndex = 42;
            // 
            // buttonAdicionarVenda
            // 
            this.buttonAdicionarVenda.Location = new System.Drawing.Point(25, 379);
            this.buttonAdicionarVenda.Name = "buttonAdicionarVenda";
            this.buttonAdicionarVenda.Size = new System.Drawing.Size(214, 23);
            this.buttonAdicionarVenda.TabIndex = 40;
            this.buttonAdicionarVenda.Text = "Adicionar Venda";
            this.buttonAdicionarVenda.UseVisualStyleBackColor = true;
            this.buttonAdicionarVenda.Click += new System.EventHandler(this.buttonAdicionarExtra_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(83, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Adicionar Venda";
            // 
            // listboxVenda
            // 
            this.listboxVenda.FormattingEnabled = true;
            this.listboxVenda.Location = new System.Drawing.Point(24, 19);
            this.listboxVenda.Name = "listboxVenda";
            this.listboxVenda.ScrollAlwaysVisible = true;
            this.listboxVenda.Size = new System.Drawing.Size(214, 108);
            this.listboxVenda.TabIndex = 40;
            // 
            // Voltar
            // 
            this.Voltar.AutoSize = true;
            this.Voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Voltar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Voltar.Location = new System.Drawing.Point(628, 20);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(57, 20);
            this.Voltar.TabIndex = 9;
            this.Voltar.Text = "Voltar";
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // FormGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 586);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormGV";
            this.Text = "FormGV";
            this.Load += new System.EventHandler(this.FormGV_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBoxnif;
        private System.Windows.Forms.TextBox textBoxnome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.ListBox listBoxCarros;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxcombustivel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxmarca;
        private System.Windows.Forms.TextBox textBoxmodelo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonAdicionarCarro;
        private System.Windows.Forms.TextBox textBoxMatricula;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxnumerochassi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAdicionarVenda;
        private System.Windows.Forms.TextBox textBoxExtra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listboxVenda;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxEstado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePickerData;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label Voltar;
    }
}