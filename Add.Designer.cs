
namespace Clientes
{
    partial class Add
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
            this.campocpf = new System.Windows.Forms.MaskedTextBox();
            this.brncpf = new System.Windows.Forms.RadioButton();
            this.btncnpj = new System.Windows.Forms.RadioButton();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txttelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtcep = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.botaoconcluir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdescri = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.campocnpj = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // campocpf
            // 
            this.campocpf.Location = new System.Drawing.Point(728, 258);
            this.campocpf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.campocpf.Mask = "000.000.000-000";
            this.campocpf.Name = "campocpf";
            this.campocpf.Size = new System.Drawing.Size(274, 26);
            this.campocpf.TabIndex = 73;
            // 
            // brncpf
            // 
            this.brncpf.AutoSize = true;
            this.brncpf.Location = new System.Drawing.Point(662, 260);
            this.brncpf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.brncpf.Name = "brncpf";
            this.brncpf.Size = new System.Drawing.Size(58, 24);
            this.brncpf.TabIndex = 85;
            this.brncpf.TabStop = true;
            this.brncpf.Text = "CPF";
            this.brncpf.UseVisualStyleBackColor = true;
            // 
            // btncnpj
            // 
            this.btncnpj.AutoSize = true;
            this.btncnpj.Location = new System.Drawing.Point(538, 263);
            this.btncnpj.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btncnpj.Name = "btncnpj";
            this.btncnpj.Size = new System.Drawing.Size(67, 24);
            this.btncnpj.TabIndex = 84;
            this.btncnpj.TabStop = true;
            this.btncnpj.Text = "CNPJ";
            this.btncnpj.UseVisualStyleBackColor = true;
            this.btncnpj.CheckedChanged += new System.EventHandler(this.btncnpj_CheckedChanged);
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(675, 189);
            this.txtnumero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(238, 26);
            this.txtnumero.TabIndex = 71;
            // 
            // txtendereco
            // 
            this.txtendereco.Location = new System.Drawing.Point(183, 189);
            this.txtendereco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(380, 26);
            this.txtendereco.TabIndex = 70;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(147, 255);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(380, 26);
            this.txtemail.TabIndex = 72;
            // 
            // txttelefone
            // 
            this.txttelefone.Location = new System.Drawing.Point(614, 123);
            this.txttelefone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttelefone.Mask = "(99) 00000-0000";
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(192, 26);
            this.txttelefone.TabIndex = 68;
            // 
            // txtcep
            // 
            this.txtcep.Location = new System.Drawing.Point(878, 128);
            this.txtcep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcep.Mask = "00000-000";
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(148, 26);
            this.txtcep.TabIndex = 69;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 266);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 83;
            this.label8.Text = "E-mail:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(598, 195);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 82;
            this.label7.Text = "Número:";
            // 
            // btncancelar
            // 
            this.btncancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancelar.FlatAppearance.BorderSize = 0;
            this.btncancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btncancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Location = new System.Drawing.Point(48, 522);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(150, 51);
            this.btncancelar.TabIndex = 81;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click_1);
            // 
            // botaoconcluir
            // 
            this.botaoconcluir.BackColor = System.Drawing.Color.Turquoise;
            this.botaoconcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoconcluir.FlatAppearance.BorderSize = 0;
            this.botaoconcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.botaoconcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.botaoconcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoconcluir.Location = new System.Drawing.Point(880, 520);
            this.botaoconcluir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.botaoconcluir.Name = "botaoconcluir";
            this.botaoconcluir.Size = new System.Drawing.Size(150, 51);
            this.botaoconcluir.TabIndex = 80;
            this.botaoconcluir.Text = "Concluir";
            this.botaoconcluir.UseVisualStyleBackColor = false;
            this.botaoconcluir.Click += new System.EventHandler(this.botaoconcluir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 366);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 20);
            this.label6.TabIndex = 79;
            this.label6.Text = "Descrição e Observções:";
            // 
            // txtdescri
            // 
            this.txtdescri.Location = new System.Drawing.Point(42, 408);
            this.txtdescri.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtdescri.Multiline = true;
            this.txtdescri.Name = "txtdescri";
            this.txtdescri.Size = new System.Drawing.Size(988, 102);
            this.txtdescri.TabIndex = 74;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 198);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 78;
            this.label5.Text = "Endereço:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(531, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 77;
            this.label4.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(825, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 76;
            this.label3.Text = "CEP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 75;
            this.label2.Text = "Nome:";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(124, 123);
            this.txtnome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(380, 26);
            this.txtnome.TabIndex = 67;
            // 
            // campocnpj
            // 
            this.campocnpj.Location = new System.Drawing.Point(728, 292);
            this.campocnpj.Mask = "00.000.000/0000-000";
            this.campocnpj.Name = "campocnpj";
            this.campocnpj.Size = new System.Drawing.Size(184, 26);
            this.campocnpj.TabIndex = 86;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 632);
            this.Controls.Add(this.campocnpj);
            this.Controls.Add(this.campocpf);
            this.Controls.Add(this.brncpf);
            this.Controls.Add(this.btncnpj);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.txtendereco);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txttelefone);
            this.Controls.Add(this.txtcep);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.botaoconcluir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtdescri);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Add";
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox campocpf;
        private System.Windows.Forms.RadioButton brncpf;
        private System.Windows.Forms.RadioButton btncnpj;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.MaskedTextBox txttelefone;
        private System.Windows.Forms.MaskedTextBox txtcep;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button botaoconcluir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdescri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.MaskedTextBox campocnpj;
    }
}