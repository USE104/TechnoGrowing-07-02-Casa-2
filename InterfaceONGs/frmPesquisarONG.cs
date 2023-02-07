using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InterfaceONGs
{
    public partial class frmPesquisarONG : Form
    {
        public frmPesquisarONG()
        {
            InitializeComponent();
        }

        private void frmPesquisarONG_Load(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (rdbNome.Checked == false && rdbEmail.Checked == false)
            {
                MessageBox.Show("Favor selecionar um item ", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }


            ////////////////////////////////////////////////////////////////////////////////

            if (rdbEmail.Checked && txtDescricao.Text != string.Empty)
            {
                pesquisarEmail();

            }
            if (rdbNome.Checked && txtDescricao.Text != string.Empty)
            {
                pesquisarNome();
            }
            else
            {
                MessageBox.Show("Por favor digite o registro de acordo com o formato selecionado acima", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void pesquisarEmail()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbONG where Email like '%" + txtDescricao.Text + "%'";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader dr;

            dr = comm.ExecuteReader();
            lstInformacoes.Items.Clear();
            while (dr.Read())
            {

                lstInformacoes.Items.Clear();
                lstInformacoes.Items.Add(" Email: " + dr.GetString(2));
                lstInformacoes.Items.Add(" Nome: " + dr.GetString(1));
                lstInformacoes.Items.Add(" ID: " + dr.GetString(0));
                lstInformacoes.Items.Add(" Telefone: " + dr.GetString(4));
                lstInformacoes.Items.Add(" CNPJ: " + dr.GetString(5));
                lstInformacoes.Items.Add(" Endereço: " + dr.GetString(6));
                lstInformacoes.Items.Add(" Número: " + dr.GetString(7));
                lstInformacoes.Items.Add(" Complemento: " + dr.GetString(8));
                lstInformacoes.Items.Add(" CEP: " + dr.GetString(9));
                lstInformacoes.Items.Add(" Bairro: " + dr.GetString(10));
                lstInformacoes.Items.Add(" Cidade: " + dr.GetString(11));
                lstInformacoes.Items.Add(" Categoria: " + dr.GetString(12));
                lstInformacoes.Items.Add(" Descrição: " + dr.GetString(13));
                lstInformacoes.Items.Add(" Website: " + dr.GetString(14));
                lstInformacoes.Items.Add(" Rede Social: " + dr.GetString(15));
                lstInformacoes.Items.Add(" Funcionário que cadastrou: " + dr.GetString(16));

                Conexao.fecharConexao();
            }
        }



        private void pesquisarNome()
        {

            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbONG where nome like '%" + txtDescricao.Text + "%'";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader dr;

            dr = comm.ExecuteReader();

            lstInformacoes.Items.Clear();

            while (dr.Read())
            {
                lstInformacoes.Items.Add(" Nome: " + dr.GetString(1));
                lstInformacoes.Items.Add(" ID: " + dr.GetString(0));
                lstInformacoes.Items.Add(" Email: " + dr.GetString(2));
                lstInformacoes.Items.Add(" Telefone: " + dr.GetString(4));
                lstInformacoes.Items.Add(" CNPJ: " + dr.GetString(5));
                lstInformacoes.Items.Add(" Endereço: " + dr.GetString(6));
                lstInformacoes.Items.Add(" Número: " + dr.GetString(7));
                lstInformacoes.Items.Add(" Complemento: " + dr.GetString(8));
                lstInformacoes.Items.Add(" CEP: " + dr.GetString(9));
                lstInformacoes.Items.Add(" Bairro: " + dr.GetString(10));
                lstInformacoes.Items.Add(" Cidade: " + dr.GetString(11));
                lstInformacoes.Items.Add(" Categoria: " + dr.GetString(12));
                lstInformacoes.Items.Add(" Descrição: " + dr.GetString(13));
                lstInformacoes.Items.Add(" Website: " + dr.GetString(14));
                lstInformacoes.Items.Add(" Rede Social: " + dr.GetString(15));
                lstInformacoes.Items.Add(" Funcionário que cadastrou: " + dr.GetString(16));
            }

            Conexao.fecharConexao();
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            lstInformacoes.Items.Clear();
            txtDescricao.Focus();
        }

        private void rdbEmail_CheckedChanged(object sender, EventArgs e)
        {
            lstInformacoes.Items.Clear();
            txtDescricao.Focus();
        }
    }

}


