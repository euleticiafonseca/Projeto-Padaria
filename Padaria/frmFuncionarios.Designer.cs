namespace Padaria
{
    partial class frmFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuncionarios));
            this.gpbDados = new System.Windows.Forms.GroupBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.dtpCalendario = new System.Windows.Forms.DateTimePicker();
            this.lslTel = new System.Windows.Forms.Label();
            this.mtbTel = new System.Windows.Forms.MaskedTextBox();
            this.gpbSexo = new System.Windows.Forms.GroupBox();
            this.rbMasc = new System.Windows.Forms.RadioButton();
            this.rbFem = new System.Windows.Forms.RadioButton();
            this.rbNao = new System.Windows.Forms.RadioButton();
            this.lblFoto = new System.Windows.Forms.Label();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.btnExc = new System.Windows.Forms.Button();
            this.btnAlt = new System.Windows.Forms.Button();
            this.gpbEndereco = new System.Windows.Forms.GroupBox();
            this.mtbCEP = new System.Windows.Forms.MaskedTextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtBaixo = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.painel = new System.Windows.Forms.Panel();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExc2 = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.gpbDados.SuspendLayout();
            this.gpbSexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.gpbEndereco.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbDados
            // 
            this.gpbDados.Controls.Add(this.btnAlt);
            this.gpbDados.Controls.Add(this.btnExc);
            this.gpbDados.Controls.Add(this.btnCarregar);
            this.gpbDados.Controls.Add(this.pbFoto);
            this.gpbDados.Controls.Add(this.lblFoto);
            this.gpbDados.Controls.Add(this.gpbSexo);
            this.gpbDados.Controls.Add(this.mtbTel);
            this.gpbDados.Controls.Add(this.lslTel);
            this.gpbDados.Controls.Add(this.dtpCalendario);
            this.gpbDados.Controls.Add(this.lblNascimento);
            this.gpbDados.Controls.Add(this.mtbCPF);
            this.gpbDados.Controls.Add(this.lblCPF);
            this.gpbDados.Controls.Add(this.lblEmail);
            this.gpbDados.Controls.Add(this.lblNome);
            this.gpbDados.Controls.Add(this.txtEmail);
            this.gpbDados.Controls.Add(this.txtNome);
            this.gpbDados.Controls.Add(this.txtCodigo);
            this.gpbDados.Controls.Add(this.lblCodigo);
            this.gpbDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDados.Location = new System.Drawing.Point(12, 3);
            this.gpbDados.Name = "gpbDados";
            this.gpbDados.Size = new System.Drawing.Size(760, 304);
            this.gpbDados.TabIndex = 0;
            this.gpbDados.TabStop = false;
            this.gpbDados.Text = "Dados Pessoais";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(30, 64);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(59, 20);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(95, 61);
            this.txtCodigo.MaxLength = 10;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(91, 26);
            this.txtCodigo.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(275, 61);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(135, 26);
            this.txtNome.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(506, 61);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(167, 26);
            this.txtEmail.TabIndex = 6;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(218, 61);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(435, 64);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 20);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "E-mail";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(30, 119);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(40, 20);
            this.lblCPF.TabIndex = 7;
            this.lblCPF.Text = "CPF";
            this.lblCPF.Click += new System.EventHandler(this.label4_Click);
            // 
            // mtbCPF
            // 
            this.mtbCPF.Location = new System.Drawing.Point(95, 113);
            this.mtbCPF.Mask = "999,999,999-99";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(122, 26);
            this.mtbCPF.TabIndex = 8;
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Location = new System.Drawing.Point(235, 113);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(154, 20);
            this.lblNascimento.TabIndex = 9;
            this.lblNascimento.Text = "Data de Nascimento";
            // 
            // dtpCalendario
            // 
            this.dtpCalendario.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCalendario.Location = new System.Drawing.Point(395, 111);
            this.dtpCalendario.Name = "dtpCalendario";
            this.dtpCalendario.Size = new System.Drawing.Size(122, 26);
            this.dtpCalendario.TabIndex = 10;
            this.dtpCalendario.Value = new System.DateTime(2025, 3, 20, 0, 0, 0, 0);
            this.dtpCalendario.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lslTel
            // 
            this.lslTel.AutoSize = true;
            this.lslTel.Location = new System.Drawing.Point(543, 116);
            this.lslTel.Name = "lslTel";
            this.lslTel.Size = new System.Drawing.Size(71, 20);
            this.lslTel.TabIndex = 11;
            this.lslTel.Text = "Telefone";
            // 
            // mtbTel
            // 
            this.mtbTel.Location = new System.Drawing.Point(620, 110);
            this.mtbTel.Mask = "(99) 99999-9999";
            this.mtbTel.Name = "mtbTel";
            this.mtbTel.Size = new System.Drawing.Size(133, 26);
            this.mtbTel.TabIndex = 12;
            // 
            // gpbSexo
            // 
            this.gpbSexo.Controls.Add(this.rbNao);
            this.gpbSexo.Controls.Add(this.rbFem);
            this.gpbSexo.Controls.Add(this.rbMasc);
            this.gpbSexo.Location = new System.Drawing.Point(34, 161);
            this.gpbSexo.Name = "gpbSexo";
            this.gpbSexo.Size = new System.Drawing.Size(200, 109);
            this.gpbSexo.TabIndex = 13;
            this.gpbSexo.TabStop = false;
            this.gpbSexo.Text = "Sexo";
            // 
            // rbMasc
            // 
            this.rbMasc.AutoSize = true;
            this.rbMasc.Location = new System.Drawing.Point(6, 19);
            this.rbMasc.Name = "rbMasc";
            this.rbMasc.Size = new System.Drawing.Size(98, 24);
            this.rbMasc.TabIndex = 14;
            this.rbMasc.TabStop = true;
            this.rbMasc.Text = "Masculino";
            this.rbMasc.UseVisualStyleBackColor = true;
            // 
            // rbFem
            // 
            this.rbFem.AutoSize = true;
            this.rbFem.Location = new System.Drawing.Point(6, 49);
            this.rbFem.Name = "rbFem";
            this.rbFem.Size = new System.Drawing.Size(92, 24);
            this.rbFem.TabIndex = 15;
            this.rbFem.TabStop = true;
            this.rbFem.Text = "Feminino";
            this.rbFem.UseVisualStyleBackColor = true;
            // 
            // rbNao
            // 
            this.rbNao.AutoSize = true;
            this.rbNao.Location = new System.Drawing.Point(6, 79);
            this.rbNao.Name = "rbNao";
            this.rbNao.Size = new System.Drawing.Size(169, 24);
            this.rbNao.TabIndex = 16;
            this.rbNao.TabStop = true;
            this.rbNao.Text = "Não desejo informar";
            this.rbNao.UseVisualStyleBackColor = true;
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Location = new System.Drawing.Point(254, 161);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(42, 20);
            this.lblFoto.TabIndex = 17;
            this.lblFoto.Text = "Foto";
            // 
            // pbFoto
            // 
            this.pbFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.Location = new System.Drawing.Point(302, 161);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(164, 130);
            this.pbFoto.TabIndex = 13;
            this.pbFoto.TabStop = false;
            // 
            // btnCarregar
            // 
            this.btnCarregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnCarregar.Image = ((System.Drawing.Image)(resources.GetObject("btnCarregar.Image")));
            this.btnCarregar.Location = new System.Drawing.Point(472, 161);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(75, 31);
            this.btnCarregar.TabIndex = 18;
            this.btnCarregar.UseVisualStyleBackColor = true;
            // 
            // btnExc
            // 
            this.btnExc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExc.Image = ((System.Drawing.Image)(resources.GetObject("btnExc.Image")));
            this.btnExc.Location = new System.Drawing.Point(472, 240);
            this.btnExc.Name = "btnExc";
            this.btnExc.Size = new System.Drawing.Size(75, 31);
            this.btnExc.TabIndex = 20;
            this.btnExc.UseVisualStyleBackColor = true;
            // 
            // btnAlt
            // 
            this.btnAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlt.Image = ((System.Drawing.Image)(resources.GetObject("btnAlt.Image")));
            this.btnAlt.Location = new System.Drawing.Point(472, 198);
            this.btnAlt.Name = "btnAlt";
            this.btnAlt.Size = new System.Drawing.Size(75, 31);
            this.btnAlt.TabIndex = 19;
            this.btnAlt.UseVisualStyleBackColor = true;
            // 
            // gpbEndereco
            // 
            this.gpbEndereco.Controls.Add(this.txtComplemento);
            this.gpbEndereco.Controls.Add(this.lblComplemento);
            this.gpbEndereco.Controls.Add(this.painel);
            this.gpbEndereco.Controls.Add(this.txtCidade);
            this.gpbEndereco.Controls.Add(this.lblCidade);
            this.gpbEndereco.Controls.Add(this.txtNumero);
            this.gpbEndereco.Controls.Add(this.lblNumero);
            this.gpbEndereco.Controls.Add(this.cbEstado);
            this.gpbEndereco.Controls.Add(this.lblEstado);
            this.gpbEndereco.Controls.Add(this.txtBaixo);
            this.gpbEndereco.Controls.Add(this.lblBairro);
            this.gpbEndereco.Controls.Add(this.mtbCEP);
            this.gpbEndereco.Controls.Add(this.lblCEP);
            this.gpbEndereco.Controls.Add(this.lblLogradouro);
            this.gpbEndereco.Controls.Add(this.txtLogradouro);
            this.gpbEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbEndereco.Location = new System.Drawing.Point(12, 313);
            this.gpbEndereco.Name = "gpbEndereco";
            this.gpbEndereco.Size = new System.Drawing.Size(760, 186);
            this.gpbEndereco.TabIndex = 21;
            this.gpbEndereco.TabStop = false;
            this.gpbEndereco.Text = "Endereço";
            // 
            // mtbCEP
            // 
            this.mtbCEP.Location = new System.Drawing.Point(574, 82);
            this.mtbCEP.Mask = "99999-999";
            this.mtbCEP.Name = "mtbCEP";
            this.mtbCEP.Size = new System.Drawing.Size(86, 26);
            this.mtbCEP.TabIndex = 31;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(524, 85);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(41, 20);
            this.lblCEP.TabIndex = 30;
            this.lblCEP.Text = "CEP";
            this.lblCEP.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(30, 41);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(91, 20);
            this.lblLogradouro.TabIndex = 22;
            this.lblLogradouro.Text = "Logradouro";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(134, 41);
            this.txtLogradouro.MaxLength = 100;
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(398, 26);
            this.txtLogradouro.TabIndex = 23;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(30, 82);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(51, 20);
            this.lblBairro.TabIndex = 26;
            this.lblBairro.Text = "Bairro";
            // 
            // txtBaixo
            // 
            this.txtBaixo.Location = new System.Drawing.Point(95, 79);
            this.txtBaixo.MaxLength = 100;
            this.txtBaixo.Name = "txtBaixo";
            this.txtBaixo.Size = new System.Drawing.Size(154, 26);
            this.txtBaixo.TabIndex = 27;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(255, 129);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(60, 20);
            this.lblEstado.TabIndex = 34;
            this.lblEstado.Text = "Estado";
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.ItemHeight = 20;
            this.cbEstado.Items.AddRange(new object[] {
            " AC",
            "",
            " AL",
            "",
            " AP",
            "",
            " AM",
            "",
            " BA",
            "",
            " CE",
            "",
            " DF",
            "",
            " ES",
            "",
            " GO",
            "",
            " MA",
            "",
            " MT",
            "",
            " MS",
            "",
            " MG",
            "",
            " PA",
            "",
            " PB",
            "",
            " PR",
            "",
            " PE",
            "",
            " PI",
            "",
            " RJ",
            "",
            " RN",
            "",
            " RS",
            "",
            " RO",
            "",
            " RR",
            "",
            " SC",
            "",
            " SP",
            "",
            " SE",
            "",
            " TO",
            "",
            " "});
            this.cbEstado.Location = new System.Drawing.Point(322, 121);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(152, 28);
            this.cbEstado.TabIndex = 35;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(560, 41);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(65, 20);
            this.lblNumero.TabIndex = 24;
            this.lblNumero.Text = "Número";
            this.lblNumero.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(631, 38);
            this.txtNumero.MaxLength = 10;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(62, 26);
            this.txtNumero.TabIndex = 25;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(30, 129);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(59, 20);
            this.lblCidade.TabIndex = 32;
            this.lblCidade.Text = "Cidade";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(95, 123);
            this.txtCidade.MaxLength = 50;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(154, 26);
            this.txtCidade.TabIndex = 33;
            // 
            // painel
            // 
            this.painel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.painel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painel.Location = new System.Drawing.Point(0, 192);
            this.painel.Name = "painel";
            this.painel.Size = new System.Drawing.Size(760, 53);
            this.painel.TabIndex = 15;
            // 
            // btnNovo
            // 
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(26, 509);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(84, 40);
            this.btnNovo.TabIndex = 36;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.Location = new System.Drawing.Point(123, 509);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(84, 40);
            this.btnCadastrar.TabIndex = 37;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(220, 509);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(84, 40);
            this.btnAlterar.TabIndex = 38;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnExc2
            // 
            this.btnExc2.Image = ((System.Drawing.Image)(resources.GetObject("btnExc2.Image")));
            this.btnExc2.Location = new System.Drawing.Point(314, 509);
            this.btnExc2.Name = "btnExc2";
            this.btnExc2.Size = new System.Drawing.Size(85, 40);
            this.btnExc2.TabIndex = 39;
            this.btnExc2.Text = "E&cluir";
            this.btnExc2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExc2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExc2.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(411, 509);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(84, 40);
            this.btnLimpar.TabIndex = 40;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(502, 509);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(91, 40);
            this.btnPesquisar.TabIndex = 41;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(666, 509);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(99, 40);
            this.btnVoltar.TabIndex = 42;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(255, 85);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(108, 20);
            this.lblComplemento.TabIndex = 28;
            this.lblComplemento.Text = "Complemento";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(363, 79);
            this.txtComplemento.MaxLength = 20;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(154, 26);
            this.txtComplemento.TabIndex = 29;
            // 
            // frmFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExc2);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.gpbEndereco);
            this.Controls.Add(this.gpbDados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Padaria - Funcionarios";
            this.gpbDados.ResumeLayout(false);
            this.gpbDados.PerformLayout();
            this.gpbSexo.ResumeLayout(false);
            this.gpbSexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.gpbEndereco.ResumeLayout(false);
            this.gpbEndereco.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDados;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.DateTimePicker dtpCalendario;
        private System.Windows.Forms.GroupBox gpbSexo;
        private System.Windows.Forms.RadioButton rbFem;
        private System.Windows.Forms.RadioButton rbMasc;
        private System.Windows.Forms.MaskedTextBox mtbTel;
        private System.Windows.Forms.Label lslTel;
        private System.Windows.Forms.Button btnAlt;
        private System.Windows.Forms.Button btnExc;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.RadioButton rbNao;
        private System.Windows.Forms.GroupBox gpbEndereco;
        private System.Windows.Forms.MaskedTextBox mtbCEP;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtBaixo;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Panel painel;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExc2;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblComplemento;
    }
}