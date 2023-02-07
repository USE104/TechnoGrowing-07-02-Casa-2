using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace InterfaceONGs
{
    public partial class frmAdministrador : Form
    {
        public frmAdministrador()
        {
            InitializeComponent();
        }

        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        private void frmAdministrador_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            frmFuncionario abrirFunc = new frmFuncionario();
            abrirFunc.Show();
            this.Hide();
        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            frmVoluntariosONG abrirUsers = new frmVoluntariosONG();
            abrirUsers.Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHome abrirHome = new frmHome();
            abrirHome.Show();
            this.Hide();
        }


        private void btnCadastrarONG_Click_1(object sender, EventArgs e)
        {
            frmONG abrirONG = new frmONG();
            abrirONG.Show();
            this.Hide();
        }

        private void btnLoja_Click(object sender, EventArgs e)
        {
            frmLoja abrirLoja = new frmLoja();
            abrirLoja.Show();
            //esconder a página anterior da página de login
            this.Hide();
        }

        private void btnVendasLoja_Click(object sender, EventArgs e)
        {
            frmVenda abrirVendas = new frmVenda();
            abrirVendas.Show();
            this.Hide();

        }

        private void btnGerenciarUsuariosFunc_Click(object sender, EventArgs e)
        {
            frmGerenciarUsuarios abrirgerenciarUsuarios = new frmGerenciarUsuarios();
            abrirgerenciarUsuarios.Show();
            this.Hide();
        }

        private void btnFaleConosco_Click(object sender, EventArgs e)
        {
            frmPesquisarContato  Contato = new frmPesquisarContato();
            Contato.Show();
            this.ShowDialog();
        }

        private void pctLogo_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btnSAC_Click(object sender, EventArgs e)
        {
            frmSAC abrirSAC = new frmSAC();
            abrirSAC.Show();
            this.Hide();
        }
    }
}




