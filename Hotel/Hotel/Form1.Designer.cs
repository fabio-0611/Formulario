namespace Hotel
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.textPesquisa = new System.Windows.Forms.TextBox();
            this.BtnDeletar = new System.Windows.Forms.Button();
            this.BtnAdicionar = new System.Windows.Forms.Button();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textendereco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Endereço = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // datagrid
            // 
            this.datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datagrid.BackgroundColor = System.Drawing.Color.LightGreen;
            this.datagrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.datagrid.Location = new System.Drawing.Point(369, 97);
            this.datagrid.Name = "datagrid";
            this.datagrid.Size = new System.Drawing.Size(444, 73);
            this.datagrid.TabIndex = 0;
            this.datagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_CellContentClick);
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPesquisar.AutoSize = true;
            this.BtnPesquisar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnPesquisar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPesquisar.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnPesquisar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnPesquisar.FlatAppearance.BorderSize = 5;
            this.BtnPesquisar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnPesquisar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnPesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPesquisar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPesquisar.ForeColor = System.Drawing.Color.Black;
            this.BtnPesquisar.Location = new System.Drawing.Point(679, 54);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(82, 35);
            this.BtnPesquisar.TabIndex = 7;
            this.BtnPesquisar.Text = "Pesquisar";
            this.toolTip1.SetToolTip(this.BtnPesquisar, "Clique para pesquisar");
            this.BtnPesquisar.UseVisualStyleBackColor = false;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // textPesquisa
            // 
            this.textPesquisa.Location = new System.Drawing.Point(558, 63);
            this.textPesquisa.Name = "textPesquisa";
            this.textPesquisa.Size = new System.Drawing.Size(100, 20);
            this.textPesquisa.TabIndex = 2;
            // 
            // BtnDeletar
            // 
            this.BtnDeletar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDeletar.AutoSize = true;
            this.BtnDeletar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnDeletar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnDeletar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDeletar.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnDeletar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnDeletar.FlatAppearance.BorderSize = 5;
            this.BtnDeletar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnDeletar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnDeletar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeletar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeletar.ForeColor = System.Drawing.Color.Black;
            this.BtnDeletar.Location = new System.Drawing.Point(496, 176);
            this.BtnDeletar.Name = "BtnDeletar";
            this.BtnDeletar.Size = new System.Drawing.Size(68, 35);
            this.BtnDeletar.TabIndex = 3;
            this.BtnDeletar.TabStop = false;
            this.BtnDeletar.Text = "Deletar";
            this.toolTip1.SetToolTip(this.BtnDeletar, "Clique para excluir um registro");
            this.BtnDeletar.UseVisualStyleBackColor = false;
            this.BtnDeletar.Click += new System.EventHandler(this.BtnDeletar_Click);
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdicionar.AutoSize = true;
            this.BtnAdicionar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnAdicionar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAdicionar.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnAdicionar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnAdicionar.FlatAppearance.BorderSize = 5;
            this.BtnAdicionar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdicionar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdicionar.ForeColor = System.Drawing.Color.Black;
            this.BtnAdicionar.Location = new System.Drawing.Point(83, 259);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(81, 35);
            this.BtnAdicionar.TabIndex = 3;
            this.BtnAdicionar.Text = "Adicionar";
            this.toolTip1.SetToolTip(this.BtnAdicionar, "Clique para adicionar um novo cliente");
            this.BtnAdicionar.UseVisualStyleBackColor = false;
            this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCadastrar.AutoSize = true;
            this.BtnCadastrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnCadastrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCadastrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnCadastrar.FlatAppearance.BorderSize = 5;
            this.BtnCadastrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastrar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastrar.ForeColor = System.Drawing.Color.Black;
            this.BtnCadastrar.Location = new System.Drawing.Point(185, 259);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(82, 35);
            this.BtnCadastrar.TabIndex = 4;
            this.BtnCadastrar.Text = "Cadastrar";
            this.toolTip1.SetToolTip(this.BtnCadastrar, "Clique para Salvar");
            this.BtnCadastrar.UseVisualStyleBackColor = false;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(83, 103);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(43, 20);
            this.textBoxId.TabIndex = 6;
            // 
            // textNome
            // 
            this.textNome.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textNome.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNome.ForeColor = System.Drawing.Color.Black;
            this.textNome.Location = new System.Drawing.Point(83, 147);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(256, 25);
            this.textNome.TabIndex = 0;
            this.toolTip1.SetToolTip(this.textNome, "Digite o seu nome");
            // 
            // textendereco
            // 
            this.textendereco.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textendereco.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textendereco.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textendereco.ForeColor = System.Drawing.Color.Black;
            this.textendereco.Location = new System.Drawing.Point(83, 194);
            this.textendereco.Name = "textendereco";
            this.textendereco.Size = new System.Drawing.Size(256, 25);
            this.textendereco.TabIndex = 1;
            this.toolTip1.SetToolTip(this.textendereco, "Digite o seu endereço");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cod";
            // 
            // Endereço
            // 
            this.Endereço.AutoSize = true;
            this.Endereço.Enabled = false;
            this.Endereço.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Endereço.Location = new System.Drawing.Point(3, 154);
            this.Endereço.Name = "Endereço";
            this.Endereço.Size = new System.Drawing.Size(49, 16);
            this.Endereço.TabIndex = 10;
            this.Endereço.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Endereço:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Arial", 11.5F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(74, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Sistema de Cadastro de Cliente";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // BtnSair
            // 
            this.BtnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSair.AutoSize = true;
            this.BtnSair.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnSair.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSair.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnSair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnSair.FlatAppearance.BorderSize = 5;
            this.BtnSair.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSair.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.ForeColor = System.Drawing.Color.Black;
            this.BtnSair.Location = new System.Drawing.Point(291, 259);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(51, 35);
            this.BtnSair.TabIndex = 5;
            this.BtnSair.Text = "Sair";
            this.toolTip1.SetToolTip(this.BtnSair, "Clique para sair");
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.AutoSize = true;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.BorderSize = 5;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(589, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 35);
            this.button2.TabIndex = 15;
            this.button2.Text = "Alterar";
            this.toolTip1.SetToolTip(this.button2, "Clique para carregar todos os dados");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(0, 0);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(432, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Buscar por nome:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(369, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 30);
            this.panel1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hotel.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1032, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Endereço);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textendereco);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.BtnAdicionar);
            this.Controls.Add(this.BtnDeletar);
            this.Controls.Add(this.textPesquisa);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.datagrid);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rocha sistemas";
            this.TransparencyKey = System.Drawing.Color.Silver;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.TextBox textPesquisa;
        private System.Windows.Forms.Button BtnDeletar;
        private System.Windows.Forms.Button BtnAdicionar;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textendereco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Endereço;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Panel panel1;
    }
}

