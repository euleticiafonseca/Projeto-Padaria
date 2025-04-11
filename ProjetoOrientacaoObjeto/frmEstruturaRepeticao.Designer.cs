namespace ProjetoOrientacaoObjeto
{
    partial class frmEstruturaRepeticao
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
            this.cbbEstado = new System.Windows.Forms.ComboBox();
            this.btnCarregaEstado = new System.Windows.Forms.Button();
            this.btnCarregaListaEstados = new System.Windows.Forms.Button();
            this.ltbListaEstados = new System.Windows.Forms.ListBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblListaDesejos = new System.Windows.Forms.Label();
            this.lblInserirEstado = new System.Windows.Forms.Label();
            this.txtInserirEstado = new System.Windows.Forms.TextBox();
            this.btnInserirEstado = new System.Windows.Forms.Button();
            this.btnLimparEstado = new System.Windows.Forms.Button();
            this.btnLimpaItemSelecionado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbbEstado
            // 
            this.cbbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.Location = new System.Drawing.Point(41, 57);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(156, 26);
            this.cbbEstado.TabIndex = 0;
            this.cbbEstado.TabStop = false;
            // 
            // btnCarregaEstado
            // 
            this.btnCarregaEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregaEstado.Location = new System.Drawing.Point(65, 348);
            this.btnCarregaEstado.Name = "btnCarregaEstado";
            this.btnCarregaEstado.Size = new System.Drawing.Size(170, 48);
            this.btnCarregaEstado.TabIndex = 3;
            this.btnCarregaEstado.Text = "Carrega Estado";
            this.btnCarregaEstado.UseVisualStyleBackColor = true;
            this.btnCarregaEstado.Click += new System.EventHandler(this.btnCarregaEstado_Click);
            // 
            // btnCarregaListaEstados
            // 
            this.btnCarregaListaEstados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregaListaEstados.Location = new System.Drawing.Point(301, 348);
            this.btnCarregaListaEstados.Name = "btnCarregaListaEstados";
            this.btnCarregaListaEstados.Size = new System.Drawing.Size(196, 48);
            this.btnCarregaListaEstados.TabIndex = 4;
            this.btnCarregaListaEstados.Text = "Carrrega Lista de Estados";
            this.btnCarregaListaEstados.UseVisualStyleBackColor = true;
            this.btnCarregaListaEstados.Click += new System.EventHandler(this.btnCarregaListaEstados_Click);
            // 
            // ltbListaEstados
            // 
            this.ltbListaEstados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbListaEstados.FormattingEnabled = true;
            this.ltbListaEstados.ItemHeight = 18;
            this.ltbListaEstados.Location = new System.Drawing.Point(301, 65);
            this.ltbListaEstados.Name = "ltbListaEstados";
            this.ltbListaEstados.Size = new System.Drawing.Size(196, 220);
            this.ltbListaEstados.TabIndex = 4;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(38, 36);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(55, 18);
            this.lblEstado.TabIndex = 0;
            this.lblEstado.Text = "Estado";
            // 
            // lblListaDesejos
            // 
            this.lblListaDesejos.AutoSize = true;
            this.lblListaDesejos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaDesejos.Location = new System.Drawing.Point(298, 36);
            this.lblListaDesejos.Name = "lblListaDesejos";
            this.lblListaDesejos.Size = new System.Drawing.Size(118, 18);
            this.lblListaDesejos.TabIndex = 6;
            this.lblListaDesejos.Text = "Lista de Estados";
            // 
            // lblInserirEstado
            // 
            this.lblInserirEstado.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.lblInserirEstado.AutoSize = true;
            this.lblInserirEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInserirEstado.Location = new System.Drawing.Point(38, 134);
            this.lblInserirEstado.Name = "lblInserirEstado";
            this.lblInserirEstado.Size = new System.Drawing.Size(109, 18);
            this.lblInserirEstado.TabIndex = 7;
            this.lblInserirEstado.Text = "Digite o Estado";
            // 
            // txtInserirEstado
            // 
            this.txtInserirEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInserirEstado.Location = new System.Drawing.Point(41, 155);
            this.txtInserirEstado.Name = "txtInserirEstado";
            this.txtInserirEstado.Size = new System.Drawing.Size(216, 24);
            this.txtInserirEstado.TabIndex = 1;
            // 
            // btnInserirEstado
            // 
            this.btnInserirEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirEstado.Location = new System.Drawing.Point(41, 185);
            this.btnInserirEstado.Name = "btnInserirEstado";
            this.btnInserirEstado.Size = new System.Drawing.Size(106, 34);
            this.btnInserirEstado.TabIndex = 2;
            this.btnInserirEstado.Text = "Inserir Estado";
            this.btnInserirEstado.UseVisualStyleBackColor = true;
            this.btnInserirEstado.Click += new System.EventHandler(this.btnInserirEstado_Click);
            // 
            // btnLimparEstado
            // 
            this.btnLimparEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparEstado.Location = new System.Drawing.Point(153, 185);
            this.btnLimparEstado.Name = "btnLimparEstado";
            this.btnLimparEstado.Size = new System.Drawing.Size(104, 34);
            this.btnLimparEstado.TabIndex = 8;
            this.btnLimparEstado.Text = "Limpar Estado";
            this.btnLimparEstado.UseVisualStyleBackColor = true;
            this.btnLimparEstado.Click += new System.EventHandler(this.btnLimparEstado_Click);
            // 
            // btnLimpaItemSelecionado
            // 
            this.btnLimpaItemSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpaItemSelecionado.Location = new System.Drawing.Point(41, 225);
            this.btnLimpaItemSelecionado.Name = "btnLimpaItemSelecionado";
            this.btnLimpaItemSelecionado.Size = new System.Drawing.Size(216, 34);
            this.btnLimpaItemSelecionado.TabIndex = 9;
            this.btnLimpaItemSelecionado.Text = "Limpa Item Selecionado";
            this.btnLimpaItemSelecionado.UseVisualStyleBackColor = true;
            this.btnLimpaItemSelecionado.Click += new System.EventHandler(this.btnLimpaItemSelecionado_Click);
            // 
            // frmEstruturaRepeticao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 432);
            this.Controls.Add(this.btnLimpaItemSelecionado);
            this.Controls.Add(this.btnLimparEstado);
            this.Controls.Add(this.btnInserirEstado);
            this.Controls.Add(this.txtInserirEstado);
            this.Controls.Add(this.lblInserirEstado);
            this.Controls.Add(this.lblListaDesejos);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.ltbListaEstados);
            this.Controls.Add(this.btnCarregaListaEstados);
            this.Controls.Add(this.btnCarregaEstado);
            this.Controls.Add(this.cbbEstado);
            this.Name = "frmEstruturaRepeticao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estrutura de Repetição";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbEstado;
        private System.Windows.Forms.Button btnCarregaEstado;
        private System.Windows.Forms.Button btnCarregaListaEstados;
        private System.Windows.Forms.ListBox ltbListaEstados;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblListaDesejos;
        private System.Windows.Forms.Label lblInserirEstado;
        private System.Windows.Forms.TextBox txtInserirEstado;
        private System.Windows.Forms.Button btnInserirEstado;
        private System.Windows.Forms.Button btnLimparEstado;
        private System.Windows.Forms.Button btnLimpaItemSelecionado;
    }
}