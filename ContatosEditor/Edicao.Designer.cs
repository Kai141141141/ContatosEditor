namespace ContatosEditor
{
    partial class Edicao
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
            this.dvgEdicao = new System.Windows.Forms.DataGridView();
            this.btnCadastroo = new System.Windows.Forms.Button();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.BtnEditarr = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNomeEdit = new System.Windows.Forms.TextBox();
            this.txbTellEdit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxbEmailEdit = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.txbTelCadastro = new System.Windows.Forms.TextBox();
            this.lblSenhaCad = new System.Windows.Forms.Label();
            this.txbEmailcadastronovo = new System.Windows.Forms.TextBox();
            this.lblemailcadastro = new System.Windows.Forms.Label();
            this.txbNomeCad = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.gpbCadastro = new System.Windows.Forms.GroupBox();
            this.dtpAniversario = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgEdicao)).BeginInit();
            this.grbEditar.SuspendLayout();
            this.gpbCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvgEdicao
            // 
            this.dvgEdicao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgEdicao.Location = new System.Drawing.Point(268, 12);
            this.dvgEdicao.Name = "dvgEdicao";
            this.dvgEdicao.Size = new System.Drawing.Size(356, 235);
            this.dvgEdicao.TabIndex = 0;
            this.dvgEdicao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgEdicao_CellClick_1);
            this.dvgEdicao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnCadastroo
            // 
            this.btnCadastroo.Location = new System.Drawing.Point(47, 140);
            this.btnCadastroo.Name = "btnCadastroo";
            this.btnCadastroo.Size = new System.Drawing.Size(153, 22);
            this.btnCadastroo.TabIndex = 0;
            this.btnCadastroo.Text = "Cadastrar";
            this.btnCadastroo.UseVisualStyleBackColor = true;
            this.btnCadastroo.Click += new System.EventHandler(this.btnCadastroo_Click);
            // 
            // grbEditar
            // 
            this.grbEditar.Controls.Add(this.BtnEditarr);
            this.grbEditar.Controls.Add(this.label2);
            this.grbEditar.Controls.Add(this.txbNomeEdit);
            this.grbEditar.Controls.Add(this.txbTellEdit);
            this.grbEditar.Controls.Add(this.label3);
            this.grbEditar.Controls.Add(this.label4);
            this.grbEditar.Controls.Add(this.TxbEmailEdit);
            this.grbEditar.Controls.Add(this.btnCadastrar);
            this.grbEditar.Location = new System.Drawing.Point(12, 186);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(250, 153);
            this.grbEditar.TabIndex = 2;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar";
            this.grbEditar.Enter += new System.EventHandler(this.grbEditar_Enter);
            // 
            // BtnEditarr
            // 
            this.BtnEditarr.Location = new System.Drawing.Point(41, 115);
            this.BtnEditarr.Name = "BtnEditarr";
            this.BtnEditarr.Size = new System.Drawing.Size(153, 22);
            this.BtnEditarr.TabIndex = 15;
            this.BtnEditarr.Text = "Editar";
            this.BtnEditarr.UseVisualStyleBackColor = true;
            this.BtnEditarr.Click += new System.EventHandler(this.BtnEditarr_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nome ";
            // 
            // txbNomeEdit
            // 
            this.txbNomeEdit.Location = new System.Drawing.Point(61, 26);
            this.txbNomeEdit.Name = "txbNomeEdit";
            this.txbNomeEdit.Size = new System.Drawing.Size(133, 20);
            this.txbNomeEdit.TabIndex = 16;
            // 
            // txbTellEdit
            // 
            this.txbTellEdit.Location = new System.Drawing.Point(61, 78);
            this.txbTellEdit.Name = "txbTellEdit";
            this.txbTellEdit.Size = new System.Drawing.Size(133, 20);
            this.txbTellEdit.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Telefone: ";
            // 
            // TxbEmailEdit
            // 
            this.TxbEmailEdit.Location = new System.Drawing.Point(61, 52);
            this.TxbEmailEdit.Name = "TxbEmailEdit";
            this.TxbEmailEdit.Size = new System.Drawing.Size(133, 20);
            this.TxbEmailEdit.TabIndex = 18;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrar.Location = new System.Drawing.Point(36, 173);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(341, 39);
            this.btnCadastrar.TabIndex = 13;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(331, 274);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(226, 37);
            this.btnDeletar.TabIndex = 3;
            this.btnDeletar.Text = "Deletar Contato";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // txbTelCadastro
            // 
            this.txbTelCadastro.Location = new System.Drawing.Point(47, 75);
            this.txbTelCadastro.Name = "txbTelCadastro";
            this.txbTelCadastro.Size = new System.Drawing.Size(133, 20);
            this.txbTelCadastro.TabIndex = 12;
            this.txbTelCadastro.TextChanged += new System.EventHandler(this.txbTelCadastro_TextChanged);
            // 
            // lblSenhaCad
            // 
            this.lblSenhaCad.AutoSize = true;
            this.lblSenhaCad.Location = new System.Drawing.Point(-3, 80);
            this.lblSenhaCad.Name = "lblSenhaCad";
            this.lblSenhaCad.Size = new System.Drawing.Size(55, 13);
            this.lblSenhaCad.TabIndex = 11;
            this.lblSenhaCad.Text = "Telefone: ";
            // 
            // txbEmailcadastronovo
            // 
            this.txbEmailcadastronovo.Location = new System.Drawing.Point(47, 49);
            this.txbEmailcadastronovo.Name = "txbEmailcadastronovo";
            this.txbEmailcadastronovo.Size = new System.Drawing.Size(133, 20);
            this.txbEmailcadastronovo.TabIndex = 10;
            // 
            // lblemailcadastro
            // 
            this.lblemailcadastro.AutoSize = true;
            this.lblemailcadastro.Location = new System.Drawing.Point(6, 49);
            this.lblemailcadastro.Name = "lblemailcadastro";
            this.lblemailcadastro.Size = new System.Drawing.Size(35, 13);
            this.lblemailcadastro.TabIndex = 9;
            this.lblemailcadastro.Text = "Email:";
            // 
            // txbNomeCad
            // 
            this.txbNomeCad.Location = new System.Drawing.Point(47, 23);
            this.txbNomeCad.Name = "txbNomeCad";
            this.txbNomeCad.Size = new System.Drawing.Size(133, 20);
            this.txbNomeCad.TabIndex = 8;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 27);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 7;
            this.lblNome.Text = "Nome ";
            // 
            // gpbCadastro
            // 
            this.gpbCadastro.Controls.Add(this.dtpAniversario);
            this.gpbCadastro.Controls.Add(this.btnCadastroo);
            this.gpbCadastro.Controls.Add(this.lblData);
            this.gpbCadastro.Controls.Add(this.lblNome);
            this.gpbCadastro.Controls.Add(this.txbNomeCad);
            this.gpbCadastro.Controls.Add(this.txbTelCadastro);
            this.gpbCadastro.Controls.Add(this.lblemailcadastro);
            this.gpbCadastro.Controls.Add(this.lblSenhaCad);
            this.gpbCadastro.Controls.Add(this.txbEmailcadastronovo);
            this.gpbCadastro.Location = new System.Drawing.Point(12, 12);
            this.gpbCadastro.Name = "gpbCadastro";
            this.gpbCadastro.Size = new System.Drawing.Size(250, 168);
            this.gpbCadastro.TabIndex = 4;
            this.gpbCadastro.TabStop = false;
            this.gpbCadastro.Text = "Cadastro";
            // 
            // dtpAniversario
            // 
            this.dtpAniversario.Location = new System.Drawing.Point(94, 106);
            this.dtpAniversario.Name = "dtpAniversario";
            this.dtpAniversario.Size = new System.Drawing.Size(124, 20);
            this.dtpAniversario.TabIndex = 14;
            this.dtpAniversario.ValueChanged += new System.EventHandler(this.dtpAniversario_ValueChanged);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(0, 106);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(88, 13);
            this.lblData.TabIndex = 13;
            this.lblData.Text = "Data Aniversario:";
            // 
            // Edicao
            // 
            this.ClientSize = new System.Drawing.Size(636, 351);
            this.Controls.Add(this.gpbCadastro);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.dvgEdicao);
            this.Name = "Edicao";
            this.Load += new System.EventHandler(this.Edicao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgEdicao)).EndInit();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.gpbCadastro.ResumeLayout(false);
            this.gpbCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContatoss;
        private System.Windows.Forms.Button btnInserirCont;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.GroupBox grpED;
        private System.Windows.Forms.TextBox txbTeledit;
        private System.Windows.Forms.TextBox txbEmailEdi;
        private System.Windows.Forms.Label lblEmailEdi;
        private System.Windows.Forms.TextBox txbNomeEdi;
        private System.Windows.Forms.Label lblNomeE;
        private System.Windows.Forms.Label lblEmailEdit;
        private System.Windows.Forms.GroupBox grbCadastro;
        private System.Windows.Forms.TextBox txbTelCadas;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txbEmailCadastro;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox TxbnomeCadastro;
        private System.Windows.Forms.Label lblNomeCada;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDataNiverCadas;
        private System.Windows.Forms.DataGridView dvgEdicao;
        private System.Windows.Forms.Button btnCadastroo;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNomeEdit;
        private System.Windows.Forms.TextBox txbTellEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxbEmailEdit;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.TextBox txbTelCadastro;
        private System.Windows.Forms.Label lblSenhaCad;
        private System.Windows.Forms.TextBox txbEmailcadastronovo;
        private System.Windows.Forms.Label lblemailcadastro;
        private System.Windows.Forms.TextBox txbNomeCad;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox gpbCadastro;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button BtnEditarr;
        private System.Windows.Forms.DateTimePicker dtpAniversario;
    }
}