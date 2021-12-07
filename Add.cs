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
    public partial class Add : Form
    {
        conexao conn = new conexao();
        private SqlCommand cmd;

        public Add()
        {
            InitializeComponent();
        }

        private void Add_Load(object sender, EventArgs e)
        {

        }

        private void btncnpj_CheckedChanged(object sender, EventArgs e)
        {
            campocnpj.Visible = true;
            campocpf.Visible = false;

            campocnpj.Text = "";
            campocpf.Text = "";
        }
        

        private void botaoconcluir_Click(object sender, EventArgs e)
        {
            if (txtnome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o Nome!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtnome.Focus();
                return;
            }


            try
            {
                cmd = new SqlCommand("procedurecliente", conn.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@acao", SqlDbType.Int).Value = 1;
                cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtnome.Text;
                cmd.Parameters.Add("@dados", SqlDbType.VarChar).Value = campocnpj.Text;
                cmd.Parameters.Add("@contato", SqlDbType.VarChar).Value = txttelefone.Text;
                cmd.Parameters.Add("@endereco", SqlDbType.VarChar).Value = txtendereco.Text;
                cmd.Parameters.Add("@descricao", SqlDbType.VarChar).Value = txtdescri.Text;
                cmd.Parameters.Add("@emailclie", SqlDbType.VarChar).Value = txtemail.Text;
                cmd.Parameters.Add("@numero", SqlDbType.VarChar).Value = txtnumero.Text;
                cmd.Parameters.Add("@cep", SqlDbType.VarChar).Value = txtcep.Text;

                cmd.ExecuteNonQuery();
                conn.desconectar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            MessageBox.Show("Cliente Adicionado", "ADICIONADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }

        private void btncancelar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }

   
}
