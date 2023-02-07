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
    public partial class frmPesquisarVoluntarios : Form
    {
       
        public frmPesquisarVoluntarios()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmVoluntariosONG voluntariosONG= new frmVoluntariosONG();
            voluntariosONG.Show();
            this.Hide();
        }

        public void pesquisaPorCPF()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbVoluntario where CPF = '" + txtDescricao.Text + "';";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                dr.Read();

                lstInformacoes.Items.Clear();

                lstInformacoes.Items.Add(dr.GetString(1));

                Conexao.fecharConexao();
            }
            catch (Exception)
            {
                MessageBox.Show("Insira o numero do CPF", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                
            }
        }

        public void pesquisaPorNome()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbVoluntario where nome like '%" + txtDescricao.Text + "%'";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();

                lstInformacoes.Items.Clear();

                while (dr.Read())
                {
                    lstInformacoes.Items.Add(" Nome: " + dr.GetString(1));
                    lstInformacoes.Items.Add(" ID: " + dr.GetString(0));
                    lstInformacoes.Items.Add(" Data Nascimento: " + dr.GetString(2));
                    lstInformacoes.Items.Add(" Email: " + dr.GetString(3));
                    lstInformacoes.Items.Add(" Senha: " + dr.GetString(4));
                    lstInformacoes.Items.Add(" CPF: " + dr.GetString(5));
                    lstInformacoes.Items.Add(" Tel: " + dr.GetString(6));
                    lstInformacoes.Items.Add(" Experiencia: " + dr.GetString(7));
                    lstInformacoes.Items.Add("Nome Rede Social: " + dr.GetString(8));
                    lstInformacoes.Items.Add(" URL: " + dr.GetString(9));
                    lstInformacoes.Items.Add(" codFunc: " + dr.GetString(10));

                }

                Conexao.fecharConexao();
            }
            catch (Exception)
            {
                MessageBox.Show("Banco de Dados Desconectado", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        public static string dados = "";

        private void lstInformacoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            dados = lstInformacoes.SelectedItem.ToString();
            frmVoluntariosONG enviar = new frmVoluntariosONG();
            enviar.Show();
            this.ShowDialog();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (rdbNome.Checked == false && rdbCPF.Checked == false)
            {
                MessageBox.Show("Favor selecionar um item ", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            if (rdbCPF.Checked && txtDescricao.Text != string.Empty)
            {
                pesquisaPorCPF();

            }
            if (rdbNome.Checked && txtDescricao.Text != string.Empty)
            {
                pesquisaPorNome();
            }
            else
            {
                MessageBox.Show("Por favor digite o registro de acordo com o formato selecionado acima", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void frmPesquisarVoluntarios_Load(object sender, EventArgs e)
        {

        }
    }
}
