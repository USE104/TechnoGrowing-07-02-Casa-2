using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySql.Data.MySqlClient;

namespace InterfaceONGs
{
    public partial class frmLoguin : Form
    {
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        private void frmLoguin_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }
        public frmLoguin()
        {
            InitializeComponent();
        }

        //criando variavel para acesso ao sistema
        private bool logado = false;

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //executando o método acessaSistema
            logado = acessaSistema();

            if (logado)
            {
                frmHome abrir = new frmHome();
                abrir.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos","Mensagem do sistema",MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
                
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtSenha.Clear();
            ckbMostrarSenha.Checked = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        public void limparTela()
        {
            txtUsuario.Clear();
            txtSenha.Clear();
            txtUsuario.Focus();
            ckbMostrarSenha.Checked = false;
        }
        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar.Focus();
            }
        }

        public bool acessaSistema()
        {

                bool resultado = false;

                //Instanciando a classe MySqlCommand para executar comando de SQL no C#
                MySqlCommand comm = new MySqlCommand();


                //Executando comandos de sql no C#
                comm.CommandText = "select * from tbUsuario where Login='" + txtUsuario.Text + "' and Senha='" + txtSenha.Text + "'";
                comm.CommandType = CommandType.Text;

                //Abrir a conexão com o banco de dados
                comm.Connection = Conexao.obterConexao();
                MySqlDataReader dr;

            try
            {          
                //carregando no DataReader os dados
                dr = comm.ExecuteReader();

                //verificando se existe valor na pesquisa do SQL no BD.
                resultado = dr.HasRows;

                //fecha a conexão do BD
                Conexao.fecharConexao();

               
            }

            catch (Exception)
            {

                MessageBox.Show("Banco de dados desconectado", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); ;
            }
            //Retorna o valor
            return resultado;
        }

        private void ckbMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbMostrarSenha.Checked)
            {
                txtSenha.PasswordChar = (char)0;
            }
            else
            {
                txtSenha.PasswordChar = '*';
            }
        }
    }
}
