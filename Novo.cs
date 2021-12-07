using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clientes
{
    public partial class Novo : Form
    {
        conexao conn = new conexao();

        private SqlCommand cmd;
        string id;
        
        SqlDataAdapter adaptardados;
        DataTable tabeladaods = new DataTable();
        private DataSet tabedados;
        public Novo()
        {
            InitializeComponent();
        }

        private void Novo_Load(object sender, EventArgs e)
        {
            
            
            // TODO: esta linha de código carrega dados na tabela 'alanSDataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.alanSDataSet.cliente);
            listardados();
            formatargrid();
            desabilitar();
        }
        private void dados()
        {
            SqlDataAdapter adaptardados = new SqlDataAdapter(cmd);
            DataTable tabedados = new DataTable();
            adaptardados.Fill(tabedados);
        }
        //campos de pesquisa
        private void btncnpjcli_CheckedChanged(object sender, EventArgs e)
        {
            campocnpjcli.Visible = true;
            campocpfcli.Visible = false;
            camponomecli.Visible = false;
            campocnpjcli.Focus();

            campocnpjcli.Text = "";
            campocpfcli.Text = "";
            camponomecli.Text = "";
        }
        private void btnnomecli_CheckedChanged(object sender, EventArgs e)
        {
            campocnpjcli.Visible = false;
            campocpfcli.Visible = false;
            camponomecli.Visible = true;
            camponomecli.Focus();

            campocnpjcli.Text = "";
            campocpfcli.Text = "";
            camponomecli.Text = "";
        }
        private void btncpfcli_CheckedChanged(object sender, EventArgs e)
        {
            campocnpjcli.Visible = false;
            campocpfcli.Visible = true;
            camponomecli.Visible = false;
            campocpfcli.Focus();

            campocnpjcli.Text = "";
            campocpfcli.Text = "";
            camponomecli.Text = "";
        }

        private void listardados()
        {
            SqlDataAdapter adaptardados;
            DataTable tabedados = new DataTable();

            cmd = new SqlCommand("procedurecliente", conn.conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@acao", SqlDbType.Int).Value = 6;
            cmd.Parameters.Add("@statuscliente", SqlDbType.Int).Value = 1;

            adaptardados = new SqlDataAdapter(cmd);
            adaptardados.Fill(tabedados);

            this.gridcliente.DataSource = tabedados;
            conn.desconectar();
        }
        private void desabilitar()
        {
            btnalterar.Enabled = false;
            btnexcluir.Enabled = false;
            camponomecli.Visible = false;
        }
        private void gridcliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnalterar.Enabled = true;
            btnexcluir.Enabled = true;
            id = gridcliente.CurrentRow.Cells[0].Value.ToString();
        }

        private void formatargrid()
        {
            gridcliente.Columns[0].Visible = false;
            gridcliente.Columns[1].HeaderText = "CPF/CNPJ";
            gridcliente.Columns[2].HeaderText = "Telefone";
            gridcliente.Columns[3].HeaderText = "Endereço";
            gridcliente.Columns[4].HeaderText = "Nome";
            gridcliente.Columns[5].Visible = false;
            gridcliente.Columns[6].HeaderText = "Observação";
            gridcliente.Columns[7].HeaderText = "E-mail";
            gridcliente.Columns[8].HeaderText = "CEP";
            gridcliente.Columns[9].HeaderText = "Número";
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Tem certeza que quer excluir este Cliente?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {

                try
                {
                    cmd = new SqlCommand("procedurecliente", conn.conectar());
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@acao", SqlDbType.Int).Value = 3;
                    cmd.Parameters.Add("statuscliente", SqlDbType.Bit).Value = 0;
                    cmd.Parameters.Add("idcliente", SqlDbType.Int).Value = id;


                    cmd.ExecuteNonQuery();
                    conn.desconectar();




                }
                catch (Exception ex)
                {

                    throw ex;
                }

                MessageBox.Show("Cliente excluido", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void pesquisacpf()
        {
            cmd = new SqlCommand("procedurecliente", conn.conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@acao", SqlDbType.Int).Value = 5;
            cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = campocpfcli.Text;

            SqlDataAdapter adaptardados = new SqlDataAdapter(cmd);
            DataTable tabedados = new DataTable();
            adaptardados.Fill(tabedados);

            gridcliente.DataSource = tabedados;
            conn.desconectar();
        }

        private void camponomecli_TextChanged(object sender, EventArgs e)
        {
            pesquisanome();
        }

        private void pesquisanome()
        {
            cmd = new SqlCommand("procedurecliente", conn.conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@acao", SqlDbType.Int).Value = 4;
            cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = camponomecli.Text;

            SqlDataAdapter adaptardados = new SqlDataAdapter(cmd);
            DataTable tabedados = new DataTable();
            adaptardados.Fill(tabedados);

            gridcliente.DataSource = tabedados;
            conn.desconectar();
        }

        private void campocnpjcli_TextChanged(object sender, EventArgs e)
        {
            pesquisacnpj();
        }
        private void pesquisacnpj()
        {

            cmd = new SqlCommand("procedurecliente", conn.conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@acao", SqlDbType.Int).Value = 4;
            cmd.Parameters.Add("@dados", SqlDbType.VarChar).Value = campocnpjcli.Text;

            SqlDataAdapter adaptardados = new SqlDataAdapter(cmd);
            DataTable tabedados = new DataTable();
            adaptardados.Fill(tabedados);

            gridcliente.DataSource = tabedados;
            conn.desconectar();
        }
        private void campocpfcli_TextChanged(object sender, EventArgs e)
        {
            pesquisacpf();
        }

        
        private void campocnpjcli_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (campocnpjcli.Text.ToString().Trim() == "   .   .   -")
            {
                listardados();
            }
            else
            {
                pesquisacpf();
            }
        }

        private void campocpfcli_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.Show();
           
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            Alterar Alterar = new Alterar();
            Alterar.Propriedade = id.ToString();
            Alterar.ShowDialog();
        }
    }
}
