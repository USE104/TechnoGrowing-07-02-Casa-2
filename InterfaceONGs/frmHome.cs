using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace InterfaceONGs
{
    public partial class frmHome : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);


        public frmHome()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            string message = "Deseja realmente encerrar a aplicação ?";
            string title = "Mensagem do Sistema";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo; DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show(" Programa está sendo encerrado....");
                Application.Exit();
            }
            else
            {
                MessageBox.Show(" Encerramento Cancelado ");
            }
        }

        private void BtnSuporte_Click(object sender, EventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmAdministrador abrirAdmin = new frmAdministrador();
            abrirAdmin.Show();
            //esconder a página anterior da página de login
            this.Hide();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnSAC_Click(object sender, EventArgs e)
        {
            frmSAC abrirSAC = new frmSAC ();
            abrirSAC.Show();
            this.Hide ();
        }

        private void btnSupevisor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Somente o Administrador e o SAC estão funcionando");
        }

        private void btnLoja_Click(object sender, EventArgs e)
        {
            frmVenda abrirVenda = new frmVenda();
            abrirVenda.Show();
            this.Hide();
        }
    }
}
