using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
//using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InterfaceONGs
{
    public partial class frmPesquisarFuncionario : Form
    {
        //const int MF_BYCOMMAND = 0X400;
        //[DllImport("user32")]
        //static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        //[DllImport("user32")]
        //static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        //[DllImport("user32")]
        //static extern int GetMenuItemCount(IntPtr hWnd);
        public frmPesquisarFuncionario()
        {
            InitializeComponent();
        }


        private void frmPesquisar_Load(object sender, EventArgs e)
        {
            //IntPtr hMenu = GetSystemMenu(this.Handle, false);
            //int MenuCount = GetMenuItemCount(hMenu) - 1;
            //RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (rdbNome.Checked == false && rdbRegistroFuncionario.Checked == false)
            {
                MessageBox.Show("Favor selecionar um item ","Mensagem do sistema",MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
            }

            if (txtDescricao.Text == string.Empty)
            {
                MessageBox.Show("Por favor digite o registro de acordo com o formato selecionado acima", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
                
            

            if (rdbRegistroFuncionario.Checked && txtDescricao.Text != string.Empty)
            {

                pesquisaPorRegistro();
            }


            if (rdbNome.Checked && txtDescricao.Text != string.Empty)
            {
                pesquisaPorNome();
            }
        }

        public void pesquisaPorRegistro()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbFuncionario where registroFunc like '%" + txtDescricao.Text + "%'";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                dr.Read();

                //lstInformacoes.Items.Clear();

                lstInformacoes.Items.Add(" Registro: " + dr.GetString(4));
                lstInformacoes.Items.Add(" Código do Funcionário: " + dr.GetString(0));
                lstInformacoes.Items.Add(" Nome: " + dr.GetString(1));
                lstInformacoes.Items.Add(" CPF: " + dr.GetString(2));
                lstInformacoes.Items.Add(" Data de Nascimento: " + dr.GetString(3));
                lstInformacoes.Items.Add(" Nº CTPS: " + dr.GetString(5));
                lstInformacoes.Items.Add(" Série CTPS: " + dr.GetString(6));
                lstInformacoes.Items.Add(" Telefone: " + dr.GetString(7));
                lstInformacoes.Items.Add(" E-mail: " + dr.GetString(8));
                lstInformacoes.Items.Add(" Endereço: " + dr.GetString(9));
                lstInformacoes.Items.Add(" Nº: " + dr.GetString(10));
                lstInformacoes.Items.Add(" Complemento: " + dr.GetString(11));
                lstInformacoes.Items.Add(" CEP: " + dr.GetString(12));
                lstInformacoes.Items.Add(" Bairro: " + dr.GetString(13));
                lstInformacoes.Items.Add(" Cidade: " + dr.GetString(14));
                lstInformacoes.Items.Add(" Cargo: " + dr.GetString(15));

                Conexao.fecharConexao();
            }
            catch (Exception)
            {
                MessageBox.Show("Insira o numero do Registro", "Mensagem do sistema",MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
                lstInformacoes.Items.Clear();
                limparCampos();
            }
        }
        public void pesquisaPorNome()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbFuncionario where nome like '%" + txtDescricao.Text + "%'";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                
                lstInformacoes.Items.Clear();

                while (dr.Read())
                {
                    //lstInformacoes.Items.Add(dr.GetString(1) + " - " + dr.GetString(4));
                    lstInformacoes.Items.Add(" Nome: " + dr.GetString(1));
                    lstInformacoes.Items.Add(" Registro: " + dr.GetString(4));
                    lstInformacoes.Items.Add(" Código do Funcionário: " + dr.GetString(0));
                    lstInformacoes.Items.Add(" CPF: " + dr.GetString(2));
                    lstInformacoes.Items.Add(" Data de Nascimento: " + dr.GetString(3));
                    lstInformacoes.Items.Add(" Nº CTPS: " + dr.GetString(5));
                    lstInformacoes.Items.Add(" Série CTPS: " + dr.GetString(6));
                    lstInformacoes.Items.Add(" Telefone: " + dr.GetString(7));
                    lstInformacoes.Items.Add(" E-mail: " + dr.GetString(8));
                    lstInformacoes.Items.Add(" Endereço: " + dr.GetString(9));
                    lstInformacoes.Items.Add(" Nº: " + dr.GetString(10));
                    lstInformacoes.Items.Add(" Complemento: " + dr.GetString(11));
                    lstInformacoes.Items.Add(" CEP: " + dr.GetString(12));
                    lstInformacoes.Items.Add(" Bairro: " + dr.GetString(13));
                    lstInformacoes.Items.Add(" Cidade: " + dr.GetString(14));
                    lstInformacoes.Items.Add(" Cargo: " + dr.GetString(15));
                }

                Conexao.fecharConexao();
            }
            catch (Exception)
            {
                MessageBox.Show("Insira o Nome do Funcionário", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                lstInformacoes.Items.Clear();
                limparCampos();
            }
        }

        public void limparCampos()
        {
            rdbNome.Checked = false;
            rdbRegistroFuncionario.Checked = false;
            lstInformacoes.Items.Clear();
            txtDescricao.Clear();
            btnPesquisar.Focus();
        }
        public static string valor = "";

        private void lstInformacoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            valor = lstInformacoes.SelectedItem.ToString();
            frmFuncionario enviar = new frmFuncionario(valor);
            enviar.ShowDialog();

            
            
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmAdministrador GerenciarUsuarios = new frmAdministrador();
            GerenciarUsuarios.Show();
            this.Hide();
        }

        private void rdbRegistroFuncionario_CheckedChanged(object sender, EventArgs e)
        {
            lstInformacoes.Items.Clear();
            txtDescricao.Focus();
        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            lstInformacoes.Items.Clear();
            txtDescricao.Focus();
        }
    }
}
