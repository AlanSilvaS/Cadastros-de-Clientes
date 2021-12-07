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
    public partial class Alterar : Form
    {
        conexao conn = new conexao();
        public string Propriedade { get; set; }
        string id;
        SqlCommand cmd;
        public Alterar()
        {
            InitializeComponent();
        }
      



        private void Alterar_Load(object sender, EventArgs e)
        {
            this.Location = new Point(this.Width / 2, this.Height / 2 + 70);

            if (!this.Propriedade.Equals(""))
            {
                id = this.Propriedade;
            }
            listarcliente();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void listarcliente()
        {
            cmd = new SqlCommand("select * from cliente where IdCliente = @id", conn.conectar());
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", id);

            SqlDataReader dadosCliente;
            dadosCliente = cmd.ExecuteReader();

            if (dadosCliente.HasRows)
            {
                while (dadosCliente.Read())
                {
                    txtnome.Text = Convert.ToString(dadosCliente["nome"]);
                    txttelefone.Text = Convert.ToString(dadosCliente["contato"]);
                    txtendereco.Text = Convert.ToString(dadosCliente["endereco"]);
                    txtcpf.Text = Convert.ToString(dadosCliente["dados"]);
                    txtemail.Text = Convert.ToString(dadosCliente["emailclie"]);
                    txtcep.Text = Convert.ToString(dadosCliente["cep"]);
                    txtdescri.Text = Convert.ToString(dadosCliente["descricao"]);
                    txtnumero.Text = Convert.ToString(dadosCliente["numero"]);
                }
            }
            conn.desconectar();
        }

        private void botaoconcluir_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("[procedurecliente]", conn.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@acao", SqlDbType.Int).Value = 2;

                cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtnome.Text; ;
                cmd.Parameters.Add("@contato", SqlDbType.Text).Value = txttelefone.Text;
                cmd.Parameters.Add("@dados", SqlDbType.Text).Value = txtcpf.Text;
                cmd.Parameters.Add("@emailclie", SqlDbType.Text).Value = txtemail.Text;
                cmd.Parameters.Add("@endereco", SqlDbType.Text).Value = txtendereco.Text;
                cmd.Parameters.Add("@numero", SqlDbType.Text).Value = txtnumero.Text;
                cmd.Parameters.Add("@descricao", SqlDbType.Text).Value = txtdescri.Text;
                cmd.Parameters.Add("@statuscliente", SqlDbType.Int).Value = 1;
                cmd.Parameters.Add("@IdCliente", SqlDbType.Int).Value = id;



                cmd.ExecuteNonQuery();
                conn.desconectar();


            }
            catch (Exception ex)
            {
                throw ex;
            }
            MessageBox.Show("Cliente Alterado", "FORNECEDOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //limpardados();
            this.Hide();
        }
    }
}
