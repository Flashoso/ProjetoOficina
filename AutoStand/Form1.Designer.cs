namespace AutoStand
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelGC = new System.Windows.Forms.Label();
            this.labelGO = new System.Windows.Forms.Label();
            this.labelGA = new System.Windows.Forms.Label();
            this.labelGV = new System.Windows.Forms.Label();
            this.buttonGC = new System.Windows.Forms.Button();
            this.buttonGO = new System.Windows.Forms.Button();
            this.buttonGA = new System.Windows.Forms.Button();
            this.buttonGV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelGC
            // 
            this.labelGC.AutoSize = true;
            this.labelGC.Location = new System.Drawing.Point(104, 150);
            this.labelGC.Name = "labelGC";
            this.labelGC.Size = new System.Drawing.Size(96, 13);
            this.labelGC.TabIndex = 0;
            this.labelGC.Text = "Gestão de Clientes";
            // 
            // labelGO
            // 
            this.labelGO.AutoSize = true;
            this.labelGO.Location = new System.Drawing.Point(283, 150);
            this.labelGO.Name = "labelGO";
            this.labelGO.Size = new System.Drawing.Size(92, 13);
            this.labelGO.TabIndex = 1;
            this.labelGO.Text = "Gestão de Oficina";
            // 
            // labelGA
            // 
            this.labelGA.AutoSize = true;
            this.labelGA.Location = new System.Drawing.Point(457, 150);
            this.labelGA.Name = "labelGA";
            this.labelGA.Size = new System.Drawing.Size(95, 13);
            this.labelGA.TabIndex = 2;
            this.labelGA.Text = "Gestão de Aluguer";
            this.labelGA.Click += new System.EventHandler(this.labelGA_Click);
            // 
            // labelGV
            // 
            this.labelGV.AutoSize = true;
            this.labelGV.Location = new System.Drawing.Point(621, 150);
            this.labelGV.Name = "labelGV";
            this.labelGV.Size = new System.Drawing.Size(95, 13);
            this.labelGV.TabIndex = 3;
            this.labelGV.Text = "Gestão de Vendas";
            this.labelGV.Click += new System.EventHandler(this.labelGV_Click);
            // 
            // buttonGC
            // 
            this.buttonGC.Image = ((System.Drawing.Image)(resources.GetObject("buttonGC.Image")));
            this.buttonGC.Location = new System.Drawing.Point(72, 177);
            this.buttonGC.Name = "buttonGC";
            this.buttonGC.Size = new System.Drawing.Size(151, 138);
            this.buttonGC.TabIndex = 4;
            this.buttonGC.UseVisualStyleBackColor = true;
            this.buttonGC.Click += new System.EventHandler(this.buttonGC_Click);
            // 
            // buttonGO
            // 
            this.buttonGO.Image = ((System.Drawing.Image)(resources.GetObject("buttonGO.Image")));
            this.buttonGO.Location = new System.Drawing.Point(250, 177);
            this.buttonGO.Name = "buttonGO";
            this.buttonGO.Size = new System.Drawing.Size(151, 138);
            this.buttonGO.TabIndex = 5;
            this.buttonGO.UseVisualStyleBackColor = true;
            this.buttonGO.Click += new System.EventHandler(this.buttonGO_Click);
            // 
            // buttonGA
            // 
            this.buttonGA.Image = ((System.Drawing.Image)(resources.GetObject("buttonGA.Image")));
            this.buttonGA.Location = new System.Drawing.Point(427, 177);
            this.buttonGA.Name = "buttonGA";
            this.buttonGA.Size = new System.Drawing.Size(151, 138);
            this.buttonGA.TabIndex = 6;
            this.buttonGA.UseVisualStyleBackColor = true;
            this.buttonGA.Click += new System.EventHandler(this.buttonGA_Click);
            // 
            // buttonGV
            // 
            this.buttonGV.Image = ((System.Drawing.Image)(resources.GetObject("buttonGV.Image")));
            this.buttonGV.Location = new System.Drawing.Point(595, 177);
            this.buttonGV.Name = "buttonGV";
            this.buttonGV.Size = new System.Drawing.Size(151, 138);
            this.buttonGV.TabIndex = 7;
            this.buttonGV.UseVisualStyleBackColor = true;
            this.buttonGV.Click += new System.EventHandler(this.buttonGV_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGV);
            this.Controls.Add(this.buttonGA);
            this.Controls.Add(this.buttonGO);
            this.Controls.Add(this.buttonGC);
            this.Controls.Add(this.labelGV);
            this.Controls.Add(this.labelGA);
            this.Controls.Add(this.labelGO);
            this.Controls.Add(this.labelGC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGC;
        private System.Windows.Forms.Label labelGO;
        private System.Windows.Forms.Label labelGA;
        private System.Windows.Forms.Label labelGV;
        private System.Windows.Forms.Button buttonGC;
        private System.Windows.Forms.Button buttonGO;
        private System.Windows.Forms.Button buttonGA;
        private System.Windows.Forms.Button buttonGV;
    }
}

