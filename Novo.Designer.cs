
namespace Clientes
{
    partial class Novo
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Novo));
            this.gridcliente = new System.Windows.Forms.DataGridView();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dadosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusclienteDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailclieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.alanSDataSet1 = new Clientes.AlanSDataSet1();
            this.alanSDataSet = new Clientes.AlanSDataSet();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new Clientes.AlanSDataSetTableAdapters.clienteTableAdapter();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.camponomecli = new System.Windows.Forms.TextBox();
            this.btnnomecli = new System.Windows.Forms.RadioButton();
            this.btncpfcli = new System.Windows.Forms.RadioButton();
            this.btncnpjcli = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnalterar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.clienteTableAdapter1 = new Clientes.AlanSDataSet1TableAdapters.clienteTableAdapter();
            this.campocnpjcli = new System.Windows.Forms.MaskedTextBox();
            this.campocpfcli = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridcliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alanSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alanSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridcliente
            // 
            this.gridcliente.AllowUserToAddRows = false;
            this.gridcliente.AllowUserToDeleteRows = false;
            this.gridcliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridcliente.AutoGenerateColumns = false;
            this.gridcliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridcliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridcliente.BackgroundColor = System.Drawing.Color.White;
            this.gridcliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridcliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridcliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridcliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClienteDataGridViewTextBoxColumn,
            this.dadosDataGridViewTextBoxColumn,
            this.contatoDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.statusclienteDataGridViewCheckBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.emailclieDataGridViewTextBoxColumn,
            this.cepDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn});
            this.gridcliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gridcliente.DataSource = this.clienteBindingSource1;
            this.gridcliente.EnableHeadersVisualStyles = false;
            this.gridcliente.Location = new System.Drawing.Point(9, 308);
            this.gridcliente.Name = "gridcliente";
            this.gridcliente.ReadOnly = true;
            this.gridcliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridcliente.Size = new System.Drawing.Size(864, 150);
            this.gridcliente.TabIndex = 22;
            this.gridcliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridcliente_CellContentClick);
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "IdCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "IdCliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dadosDataGridViewTextBoxColumn
            // 
            this.dadosDataGridViewTextBoxColumn.DataPropertyName = "dados";
            this.dadosDataGridViewTextBoxColumn.HeaderText = "dados";
            this.dadosDataGridViewTextBoxColumn.Name = "dadosDataGridViewTextBoxColumn";
            this.dadosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contatoDataGridViewTextBoxColumn
            // 
            this.contatoDataGridViewTextBoxColumn.DataPropertyName = "contato";
            this.contatoDataGridViewTextBoxColumn.HeaderText = "contato";
            this.contatoDataGridViewTextBoxColumn.Name = "contatoDataGridViewTextBoxColumn";
            this.contatoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "endereco";
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            this.enderecoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusclienteDataGridViewCheckBoxColumn
            // 
            this.statusclienteDataGridViewCheckBoxColumn.DataPropertyName = "statuscliente";
            this.statusclienteDataGridViewCheckBoxColumn.HeaderText = "statuscliente";
            this.statusclienteDataGridViewCheckBoxColumn.Name = "statusclienteDataGridViewCheckBoxColumn";
            this.statusclienteDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailclieDataGridViewTextBoxColumn
            // 
            this.emailclieDataGridViewTextBoxColumn.DataPropertyName = "emailclie";
            this.emailclieDataGridViewTextBoxColumn.HeaderText = "emailclie";
            this.emailclieDataGridViewTextBoxColumn.Name = "emailclieDataGridViewTextBoxColumn";
            this.emailclieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cepDataGridViewTextBoxColumn
            // 
            this.cepDataGridViewTextBoxColumn.DataPropertyName = "cep";
            this.cepDataGridViewTextBoxColumn.HeaderText = "cep";
            this.cepDataGridViewTextBoxColumn.Name = "cepDataGridViewTextBoxColumn";
            this.cepDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "numero";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            this.numeroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteBindingSource1
            // 
            this.clienteBindingSource1.DataMember = "cliente";
            this.clienteBindingSource1.DataSource = this.alanSDataSet1;
            // 
            // alanSDataSet1
            // 
            this.alanSDataSet1.DataSetName = "AlanSDataSet1";
            this.alanSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alanSDataSet
            // 
            this.alanSDataSet.DataSetName = "AlanSDataSet";
            this.alanSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.alanSDataSet;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // btnexcluir
            // 
            this.btnexcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnexcluir.BackColor = System.Drawing.Color.Turquoise;
            this.btnexcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnexcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexcluir.FlatAppearance.BorderSize = 0;
            this.btnexcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnexcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnexcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexcluir.Location = new System.Drawing.Point(932, 276);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(95, 29);
            this.btnexcluir.TabIndex = 37;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = false;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // camponomecli
            // 
            this.camponomecli.Location = new System.Drawing.Point(64, 167);
            this.camponomecli.Name = "camponomecli";
            this.camponomecli.Size = new System.Drawing.Size(256, 26);
            this.camponomecli.TabIndex = 36;
            // 
            // btnnomecli
            // 
            this.btnnomecli.AutoSize = true;
            this.btnnomecli.Location = new System.Drawing.Point(266, 121);
            this.btnnomecli.Name = "btnnomecli";
            this.btnnomecli.Size = new System.Drawing.Size(69, 24);
            this.btnnomecli.TabIndex = 35;
            this.btnnomecli.TabStop = true;
            this.btnnomecli.Text = "Nome";
            this.btnnomecli.UseVisualStyleBackColor = true;
            this.btnnomecli.CheckedChanged += new System.EventHandler(this.btnnomecli_CheckedChanged);
            // 
            // btncpfcli
            // 
            this.btncpfcli.AutoSize = true;
            this.btncpfcli.Location = new System.Drawing.Point(178, 121);
            this.btncpfcli.Name = "btncpfcli";
            this.btncpfcli.Size = new System.Drawing.Size(58, 24);
            this.btncpfcli.TabIndex = 34;
            this.btncpfcli.TabStop = true;
            this.btncpfcli.Text = "CPF";
            this.btncpfcli.UseVisualStyleBackColor = true;
            this.btncpfcli.CheckedChanged += new System.EventHandler(this.btncpfcli_CheckedChanged);
            // 
            // btncnpjcli
            // 
            this.btncnpjcli.AutoSize = true;
            this.btncnpjcli.Location = new System.Drawing.Point(90, 121);
            this.btncnpjcli.Name = "btncnpjcli";
            this.btncnpjcli.Size = new System.Drawing.Size(67, 24);
            this.btncnpjcli.TabIndex = 33;
            this.btncnpjcli.TabStop = true;
            this.btncnpjcli.Text = "CNPJ";
            this.btncnpjcli.UseVisualStyleBackColor = true;
            this.btncnpjcli.CheckedChanged += new System.EventHandler(this.btncnpjcli_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Burscar";
            // 
            // btnalterar
            // 
            this.btnalterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnalterar.BackColor = System.Drawing.Color.Turquoise;
            this.btnalterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnalterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnalterar.FlatAppearance.BorderSize = 0;
            this.btnalterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnalterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnalterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnalterar.Location = new System.Drawing.Point(932, 220);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(95, 29);
            this.btnalterar.TabIndex = 31;
            this.btnalterar.Text = "Alterar";
            this.btnalterar.UseVisualStyleBackColor = false;
            this.btnalterar.Click += new System.EventHandler(this.btnalterar_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Turquoise;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(932, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 29);
            this.button1.TabIndex = 30;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(9, 79);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(864, 10);
            this.panel3.TabIndex = 38;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(879, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 900);
            this.panel2.TabIndex = 39;
            // 
            // clienteTableAdapter1
            // 
            this.clienteTableAdapter1.ClearBeforeFill = true;
            // 
            // campocnpjcli
            // 
            this.campocnpjcli.Location = new System.Drawing.Point(64, 167);
            this.campocnpjcli.Mask = "000.000.000/0000-00";
            this.campocnpjcli.Name = "campocnpjcli";
            this.campocnpjcli.Size = new System.Drawing.Size(164, 26);
            this.campocnpjcli.TabIndex = 40;
            this.campocnpjcli.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.campocnpjcli_MaskInputRejected);
            // 
            // campocpfcli
            // 
            this.campocpfcli.Location = new System.Drawing.Point(64, 167);
            this.campocpfcli.Mask = "000.000.000-00";
            this.campocpfcli.Name = "campocpfcli";
            this.campocpfcli.Size = new System.Drawing.Size(164, 26);
            this.campocpfcli.TabIndex = 41;
            this.campocpfcli.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.campocpfcli_MaskInputRejected);
            // 
            // Novo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 692);
            this.Controls.Add(this.campocpfcli);
            this.Controls.Add(this.campocnpjcli);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.camponomecli);
            this.Controls.Add(this.btnnomecli);
            this.Controls.Add(this.btncpfcli);
            this.Controls.Add(this.btncnpjcli);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnalterar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridcliente);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Novo";
            this.Text = "Novo";
            this.Load += new System.EventHandler(this.Novo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridcliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alanSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alanSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gridcliente;
        private AlanSDataSet alanSDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private AlanSDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dadosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusclienteDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailclieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.TextBox camponomecli;
        private System.Windows.Forms.RadioButton btnnomecli;
        private System.Windows.Forms.RadioButton btncpfcli;
        private System.Windows.Forms.RadioButton btncnpjcli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private AlanSDataSet1 alanSDataSet1;
        private System.Windows.Forms.BindingSource clienteBindingSource1;
        private AlanSDataSet1TableAdapters.clienteTableAdapter clienteTableAdapter1;
        private System.Windows.Forms.MaskedTextBox campocnpjcli;
        private System.Windows.Forms.MaskedTextBox campocpfcli;
    }
}