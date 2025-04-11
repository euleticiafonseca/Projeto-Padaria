namespace ProjetoOrientacaoObjeto
{
    partial class frmProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdutos));
            this.gpbCadastro = new System.Windows.Forms.GroupBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblDataSaida = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.gpbRegistros = new System.Windows.Forms.GroupBox();
            this.lblEntradaReg = new System.Windows.Forms.Label();
            this.lblSaidaReg = new System.Windows.Forms.Label();
            this.lblTotalReg = new System.Windows.Forms.Label();
            this.lblQuantidadeReg = new System.Windows.Forms.Label();
            this.lblValorReg = new System.Windows.Forms.Label();
            this.lblDescricaoReg = new System.Windows.Forms.Label();
            this.lblCodigoReg = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.dtpDataEntrada = new System.Windows.Forms.DateTimePicker();
            this.dtpDataSaida = new System.Windows.Forms.DateTimePicker();
            this.lblMostrarDescricao = new System.Windows.Forms.Label();
            this.lblMostrarCodigo = new System.Windows.Forms.Label();
            this.lblMostrarValor = new System.Windows.Forms.Label();
            this.lblMostrarQuantidade = new System.Windows.Forms.Label();
            this.lblMostrarTotal = new System.Windows.Forms.Label();
            this.lblMostrarEntrada = new System.Windows.Forms.Label();
            this.lblMostrarsaida = new System.Windows.Forms.Label();
            this.gpbCadastro.SuspendLayout();
            this.gpbRegistros.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbCadastro
            // 
            this.gpbCadastro.Controls.Add(this.dtpDataSaida);
            this.gpbCadastro.Controls.Add(this.dtpDataEntrada);
            this.gpbCadastro.Controls.Add(this.txtDescricao);
            this.gpbCadastro.Controls.Add(this.txtCodigo);
            this.gpbCadastro.Controls.Add(this.txtValor);
            this.gpbCadastro.Controls.Add(this.txtTotal);
            this.gpbCadastro.Controls.Add(this.txtQuantidade);
            this.gpbCadastro.Controls.Add(this.lblDataSaida);
            this.gpbCadastro.Controls.Add(this.lblTotal);
            this.gpbCadastro.Controls.Add(this.lblQuantidade);
            this.gpbCadastro.Controls.Add(this.lblDataEntrada);
            this.gpbCadastro.Controls.Add(this.lblValor);
            this.gpbCadastro.Controls.Add(this.lblDescricao);
            this.gpbCadastro.Controls.Add(this.lblCodigo);
            this.gpbCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCadastro.Location = new System.Drawing.Point(12, 12);
            this.gpbCadastro.Name = "gpbCadastro";
            this.gpbCadastro.Size = new System.Drawing.Size(651, 242);
            this.gpbCadastro.TabIndex = 0;
            this.gpbCadastro.TabStop = false;
            this.gpbCadastro.Text = "Cadastro";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(131, 40);
            this.txtDescricao.MaxLength = 100;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(422, 24);
            this.txtDescricao.TabIndex = 2;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(131, 90);
            this.txtCodigo.MaxLength = 5;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(52, 24);
            this.txtCodigo.TabIndex = 3;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(128, 133);
            this.txtValor.MaxLength = 5;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(55, 24);
            this.txtValor.TabIndex = 4;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(453, 87);
            this.txtTotal.MaxLength = 10;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(65, 24);
            this.txtTotal.TabIndex = 5;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(138, 181);
            this.txtQuantidade.MaxLength = 5;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(64, 24);
            this.txtQuantidade.TabIndex = 1;
            // 
            // lblDataSaida
            // 
            this.lblDataSaida.AutoSize = true;
            this.lblDataSaida.Location = new System.Drawing.Point(404, 199);
            this.lblDataSaida.Name = "lblDataSaida";
            this.lblDataSaida.Size = new System.Drawing.Size(100, 18);
            this.lblDataSaida.TabIndex = 6;
            this.lblDataSaida.Text = "Data de Saída";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(404, 90);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(41, 18);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(49, 184);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(83, 18);
            this.lblQuantidade.TabIndex = 4;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.AutoSize = true;
            this.lblDataEntrada.Location = new System.Drawing.Point(404, 157);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(114, 18);
            this.lblDataEntrada.TabIndex = 3;
            this.lblDataEntrada.Text = "Data de Entrada";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(49, 133);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(42, 18);
            this.lblValor.TabIndex = 2;
            this.lblValor.Text = "Valor";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(49, 43);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(76, 18);
            this.lblDescricao.TabIndex = 1;
            this.lblDescricao.Text = "Descrição";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(49, 90);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(56, 18);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // gpbRegistros
            // 
            this.gpbRegistros.Controls.Add(this.lblMostrarsaida);
            this.gpbRegistros.Controls.Add(this.lblMostrarEntrada);
            this.gpbRegistros.Controls.Add(this.lblMostrarTotal);
            this.gpbRegistros.Controls.Add(this.lblMostrarQuantidade);
            this.gpbRegistros.Controls.Add(this.lblMostrarValor);
            this.gpbRegistros.Controls.Add(this.lblMostrarCodigo);
            this.gpbRegistros.Controls.Add(this.lblMostrarDescricao);
            this.gpbRegistros.Controls.Add(this.lblEntradaReg);
            this.gpbRegistros.Controls.Add(this.lblSaidaReg);
            this.gpbRegistros.Controls.Add(this.lblTotalReg);
            this.gpbRegistros.Controls.Add(this.lblQuantidadeReg);
            this.gpbRegistros.Controls.Add(this.lblValorReg);
            this.gpbRegistros.Controls.Add(this.lblDescricaoReg);
            this.gpbRegistros.Controls.Add(this.lblCodigoReg);
            this.gpbRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbRegistros.Location = new System.Drawing.Point(12, 260);
            this.gpbRegistros.Name = "gpbRegistros";
            this.gpbRegistros.Size = new System.Drawing.Size(651, 205);
            this.gpbRegistros.TabIndex = 1;
            this.gpbRegistros.TabStop = false;
            this.gpbRegistros.Text = "Registros";
            // 
            // lblEntradaReg
            // 
            this.lblEntradaReg.AutoSize = true;
            this.lblEntradaReg.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntradaReg.Location = new System.Drawing.Point(371, 128);
            this.lblEntradaReg.Name = "lblEntradaReg";
            this.lblEntradaReg.Size = new System.Drawing.Size(110, 16);
            this.lblEntradaReg.TabIndex = 16;
            this.lblEntradaReg.Text = "Data de Entrada:";
            // 
            // lblSaidaReg
            // 
            this.lblSaidaReg.AutoSize = true;
            this.lblSaidaReg.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaidaReg.Location = new System.Drawing.Point(371, 175);
            this.lblSaidaReg.Name = "lblSaidaReg";
            this.lblSaidaReg.Size = new System.Drawing.Size(96, 16);
            this.lblSaidaReg.TabIndex = 16;
            this.lblSaidaReg.Text = "Data de Saída:";
            // 
            // lblTotalReg
            // 
            this.lblTotalReg.AutoSize = true;
            this.lblTotalReg.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalReg.Location = new System.Drawing.Point(371, 82);
            this.lblTotalReg.Name = "lblTotalReg";
            this.lblTotalReg.Size = new System.Drawing.Size(43, 16);
            this.lblTotalReg.TabIndex = 16;
            this.lblTotalReg.Text = "Total:";
            // 
            // lblQuantidadeReg
            // 
            this.lblQuantidadeReg.AutoSize = true;
            this.lblQuantidadeReg.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidadeReg.Location = new System.Drawing.Point(29, 175);
            this.lblQuantidadeReg.Name = "lblQuantidadeReg";
            this.lblQuantidadeReg.Size = new System.Drawing.Size(83, 16);
            this.lblQuantidadeReg.TabIndex = 16;
            this.lblQuantidadeReg.Text = "Quantidade:";
            // 
            // lblValorReg
            // 
            this.lblValorReg.AutoSize = true;
            this.lblValorReg.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorReg.Location = new System.Drawing.Point(29, 128);
            this.lblValorReg.Name = "lblValorReg";
            this.lblValorReg.Size = new System.Drawing.Size(44, 16);
            this.lblValorReg.TabIndex = 16;
            this.lblValorReg.Text = "Valor:";
            // 
            // lblDescricaoReg
            // 
            this.lblDescricaoReg.AutoSize = true;
            this.lblDescricaoReg.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoReg.Location = new System.Drawing.Point(29, 39);
            this.lblDescricaoReg.Name = "lblDescricaoReg";
            this.lblDescricaoReg.Size = new System.Drawing.Size(70, 16);
            this.lblDescricaoReg.TabIndex = 16;
            this.lblDescricaoReg.Text = "Descrição:";
            // 
            // lblCodigoReg
            // 
            this.lblCodigoReg.AutoSize = true;
            this.lblCodigoReg.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoReg.Location = new System.Drawing.Point(29, 82);
            this.lblCodigoReg.Name = "lblCodigoReg";
            this.lblCodigoReg.Size = new System.Drawing.Size(55, 16);
            this.lblCodigoReg.TabIndex = 16;
            this.lblCodigoReg.Text = "Código:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrar.Location = new System.Drawing.Point(44, 490);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(172, 48);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.Location = new System.Drawing.Point(440, 491);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(172, 48);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.Location = new System.Drawing.Point(242, 490);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(172, 48);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // dtpDataEntrada
            // 
            this.dtpDataEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEntrada.Location = new System.Drawing.Point(524, 152);
            this.dtpDataEntrada.Name = "dtpDataEntrada";
            this.dtpDataEntrada.Size = new System.Drawing.Size(98, 24);
            this.dtpDataEntrada.TabIndex = 8;
            this.dtpDataEntrada.Value = new System.DateTime(2025, 4, 9, 11, 13, 26, 0);
            // 
            // dtpDataSaida
            // 
            this.dtpDataSaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataSaida.Location = new System.Drawing.Point(524, 194);
            this.dtpDataSaida.Name = "dtpDataSaida";
            this.dtpDataSaida.Size = new System.Drawing.Size(98, 24);
            this.dtpDataSaida.TabIndex = 9;
            this.dtpDataSaida.Value = new System.DateTime(2025, 4, 9, 11, 13, 26, 0);
            // 
            // lblMostrarDescricao
            // 
            this.lblMostrarDescricao.AutoSize = true;
            this.lblMostrarDescricao.Location = new System.Drawing.Point(107, 36);
            this.lblMostrarDescricao.Name = "lblMostrarDescricao";
            this.lblMostrarDescricao.Size = new System.Drawing.Size(0, 18);
            this.lblMostrarDescricao.TabIndex = 10;
            // 
            // lblMostrarCodigo
            // 
            this.lblMostrarCodigo.AutoSize = true;
            this.lblMostrarCodigo.Location = new System.Drawing.Point(107, 80);
            this.lblMostrarCodigo.Name = "lblMostrarCodigo";
            this.lblMostrarCodigo.Size = new System.Drawing.Size(0, 18);
            this.lblMostrarCodigo.TabIndex = 17;
            // 
            // lblMostrarValor
            // 
            this.lblMostrarValor.AutoSize = true;
            this.lblMostrarValor.Location = new System.Drawing.Point(93, 125);
            this.lblMostrarValor.Name = "lblMostrarValor";
            this.lblMostrarValor.Size = new System.Drawing.Size(0, 18);
            this.lblMostrarValor.TabIndex = 18;
            // 
            // lblMostrarQuantidade
            // 
            this.lblMostrarQuantidade.AutoSize = true;
            this.lblMostrarQuantidade.Location = new System.Drawing.Point(128, 172);
            this.lblMostrarQuantidade.Name = "lblMostrarQuantidade";
            this.lblMostrarQuantidade.Size = new System.Drawing.Size(0, 18);
            this.lblMostrarQuantidade.TabIndex = 19;
            // 
            // lblMostrarTotal
            // 
            this.lblMostrarTotal.AutoSize = true;
            this.lblMostrarTotal.Location = new System.Drawing.Point(420, 80);
            this.lblMostrarTotal.Name = "lblMostrarTotal";
            this.lblMostrarTotal.Size = new System.Drawing.Size(0, 18);
            this.lblMostrarTotal.TabIndex = 20;
            // 
            // lblMostrarEntrada
            // 
            this.lblMostrarEntrada.AutoSize = true;
            this.lblMostrarEntrada.Location = new System.Drawing.Point(492, 125);
            this.lblMostrarEntrada.Name = "lblMostrarEntrada";
            this.lblMostrarEntrada.Size = new System.Drawing.Size(0, 18);
            this.lblMostrarEntrada.TabIndex = 21;
            // 
            // lblMostrarsaida
            // 
            this.lblMostrarsaida.AutoSize = true;
            this.lblMostrarsaida.Location = new System.Drawing.Point(492, 172);
            this.lblMostrarsaida.Name = "lblMostrarsaida";
            this.lblMostrarsaida.Size = new System.Drawing.Size(0, 18);
            this.lblMostrarsaida.TabIndex = 22;
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 550);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.gpbRegistros);
            this.Controls.Add(this.gpbCadastro);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.gpbCadastro.ResumeLayout(false);
            this.gpbCadastro.PerformLayout();
            this.gpbRegistros.ResumeLayout(false);
            this.gpbRegistros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbCadastro;
        private System.Windows.Forms.GroupBox gpbRegistros;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblDataSaida;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblDataEntrada;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblEntradaReg;
        private System.Windows.Forms.Label lblSaidaReg;
        private System.Windows.Forms.Label lblTotalReg;
        private System.Windows.Forms.Label lblQuantidadeReg;
        private System.Windows.Forms.Label lblValorReg;
        private System.Windows.Forms.Label lblDescricaoReg;
        private System.Windows.Forms.Label lblCodigoReg;
        private System.Windows.Forms.DateTimePicker dtpDataSaida;
        private System.Windows.Forms.DateTimePicker dtpDataEntrada;
        private System.Windows.Forms.Label lblMostrarsaida;
        private System.Windows.Forms.Label lblMostrarEntrada;
        private System.Windows.Forms.Label lblMostrarTotal;
        private System.Windows.Forms.Label lblMostrarQuantidade;
        private System.Windows.Forms.Label lblMostrarValor;
        private System.Windows.Forms.Label lblMostrarCodigo;
        private System.Windows.Forms.Label lblMostrarDescricao;
    }
}